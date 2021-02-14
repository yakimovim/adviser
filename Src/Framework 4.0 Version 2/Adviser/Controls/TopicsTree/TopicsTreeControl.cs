using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EdlinSoftware.Adviser.Properties;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser.Controls.TopicsTree
{
    public partial class TopicsTreeControl : UserControl
    {
        private TreeNode m_ContextMenuNode = null;

        /// <summary>
        /// Selected topic changed.
        /// </summary>
        public event EventHandler SelectedTopicChanged;

        /// <summary>
        /// Selected topic.
        /// </summary>
        [Browsable(false)]
        public Topic SelectedTopic
        {
            get
            {
                if (tvTopics.SelectedNode == null)
                    return null;
                if (tvTopics.SelectedNode.Tag == null)
                    return null;
                if (!(tvTopics.SelectedNode.Tag is Topic))
                    return null;
                return (Topic)tvTopics.SelectedNode.Tag;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public TopicsTreeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles control loading.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            FillTopicsTree();
            SetControlsState();
        }

        /// <summary>
        /// Handles expanding of topic's children.
        /// </summary>
        private void OnBeforeTopicExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Action == TreeViewAction.Expand)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    try
                    {
                        progressBar.Value = 0;
                        progressBar.Maximum = e.Node.Nodes.Count;
                        progressBar.Visible = true;

                        foreach (TreeNode subNode in e.Node.Nodes)
                        {
                            progressBar.Value++;

                            if (string.IsNullOrEmpty(subNode.Text))
                            {
                                Topic topic = (Topic)subNode.Tag;
                                subNode.Text = topic.Title;
                                subNode.ToolTipText = topic.Tooltip;

                                if (topic.SubTopics.Count > 0)
                                {
                                    foreach (Topic subTopic in topic.SubTopics)
                                    {
                                        TreeNode childNode = new TreeNode();
                                        childNode.Tag = subTopic;

                                        subNode.Nodes.Add(childNode);
                                    }
                                }
                            }
                        }

                        SortTopics(e.Node.Nodes);
                    }
                    finally
                    { progressBar.Visible = false; }
                }
            }
        }

        /// <summary>
        /// Handles adding of new subtopic.
        /// </summary>
        private void OnAddTopic(object sender, EventArgs e)
        { AddNewTopic(tvTopics.SelectedNode); }

        /// <summary>
        /// Handles adding of new top level topic.
        /// </summary>
        private void OnAddTopTopic(object sender, EventArgs e)
        { AddNewTopic(); }

        /// <summary>
        /// Handles deleting of topic.
        /// </summary>
        private void OnDeleteTopic(object sender, EventArgs e)
        { DeleteTopic(); }

        /// <summary>
        /// Handles key pressing in topics tree.
        /// </summary>
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteTopic();
                    break;
                case Keys.Insert:
                    AddNewTopic(tvTopics.SelectedNode);
                    break;
                case Keys.Space:
                    if (tvTopics.SelectedNode != null)
                    {
                        if (tvTopics.SelectedNode.IsExpanded)
                            tvTopics.SelectedNode.Collapse();
                        else
                            tvTopics.SelectedNode.Expand();
                    }
                    break;
            }
        }

        /// <summary>
        /// Handles mouse click for Drag-n-drop operation.
        /// </summary>
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeNode selNode = tvTopics.GetNodeAt(new Point(e.X, e.Y));
                if (selNode != null)
                {
                    tvTopics.SelectedNode = selNode;
                    this.DoDragDrop(selNode, DragDropEffects.Move);
                }
            }
        }

        /// <summary>
        /// Handles Drag-n-drop operation.
        /// </summary>
        private void OnDragEnter(object sender, DragEventArgs e)
        { e.Effect = DragDropEffects.Move; }

        /// <summary>
        /// Handles Drag-n-drop operation finishing.
        /// </summary>
        private void OnDragDrop(object sender, DragEventArgs e)
        {
            try
            {
                TreeNode moveNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (moveNode == null)
                { return; }
                Topic moveTopic = (Topic)moveNode.Tag;

                Topic targetTopic;
                TreeNode targetNode = tvTopics.GetNodeAt(tvTopics.PointToClient(new Point(e.X, e.Y)));
                if (targetNode == null)
                {
                    // Move to the top level.
                    targetTopic = null;
                }
                else
                {
                    // Do not move to its own successors.
                    TreeNode parentNode = targetNode;
                    while (parentNode != null)
                    {
                        if (moveNode == parentNode)
                            return;
                        parentNode = parentNode.Parent;
                    }

                    targetTopic = (Topic)targetNode.Tag;
                }

                if (moveNode.Parent != null)
                    moveNode.Parent.Nodes.Remove(moveNode);
                else
                    tvTopics.Nodes.Remove(moveNode);

                if (targetNode != null)
                { targetNode.Nodes.Add(moveNode); }
                else
                { tvTopics.Nodes.Add(moveNode); }

                if (moveTopic.Parent != null)
                    moveTopic.Parent.SubTopics.Remove(moveTopic);
                moveTopic.Parent = targetTopic;

                if (targetTopic != null)
                    targetTopic.SubTopics.Add(moveTopic);

                AdviserStorage.Current.SaveChanges();

                if (targetNode == null)
                    SortTopics(tvTopics.Nodes);
                else
                    SortTopics(targetNode.Nodes);
            }
            catch
            { }
        }

        /// <summary>
        /// Handles selecting of topics.
        /// </summary>
        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            SetControlsState();
            OnSelectedTopicChanged();
        }

        /// <summary>
        /// Handles creation of topic through menu.
        /// </summary>
        private void OnMenuCreateTopic(object sender, EventArgs e)
        {
            if (m_ContextMenuNode == null)
                AddNewTopic();
            else
                AddNewTopic(tvTopics.SelectedNode);
        }

        /// <summary>
        /// Handles deleting of topic through menu.
        /// </summary>
        private void OnMenuDeleteTopic(object sender, EventArgs e)
        {
            DeleteTopic();
        }

        /// <summary>
        /// Handles context menu opening.
        /// </summary>
        private void OnMenuOpening(object sender, CancelEventArgs e)
        {
            Point pt = tvTopics.PointToClient(Control.MousePosition);
            m_ContextMenuNode = tvTopics.GetNodeAt(pt);
            if (m_ContextMenuNode == null)
            {
                deleteTopicToolStripMenuItem.Enabled = false;
                propertiesToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteTopicToolStripMenuItem.Enabled = true;
                propertiesToolStripMenuItem.Enabled = true;
                tvTopics.SelectedNode = m_ContextMenuNode;
            }
        }

        /// <summary>
        /// Shows topic properties.
        /// </summary>
        private void OnMenuTopicProperties(object sender, EventArgs e)
        {
            ShowTopicProperties();
        }

        /// <summary>
        /// Shows properties of selected topic.
        /// </summary>
        private void OnTopicProperties(object sender, EventArgs e)
        {
            ShowTopicProperties();
        }

        /// <summary>
        /// Fills tree of topics with top level topics.
        /// </summary>
        public void FillTopicsTree()
        {
            tvTopics.Nodes.Clear();
            if (this.DesignMode)
            { return; }

            var coll = AdviserStorage.Current.Topics.Where(t => t.ParentId.HasValue == false).ToList();

            try
            {
                progressBar.Value = 0;
                progressBar.Maximum = coll.Count;
                progressBar.Visible = true;

                foreach (Topic topic in coll)
                {
                    progressBar.Value++;

                    TreeNode topicNode = new TreeNode();
                    topicNode.Tag = topic;
                    topicNode.Text = topic.Title;
                    topicNode.ToolTipText = topic.Tooltip;

                    if (topic.SubTopics.Count > 0)
                    {
                        foreach (Topic subTopic in topic.SubTopics)
                        {
                            TreeNode subTopicNode = new TreeNode();
                            subTopicNode.Tag = subTopic;

                            topicNode.Nodes.Add(subTopicNode);
                        }
                    }

                    tvTopics.Nodes.Add(topicNode);
                }

                SortTopics(tvTopics.Nodes);
            }
            finally
            { progressBar.Visible = false; }
        }

        /// <summary>
        /// Changes state of controls.
        /// </summary>
        private void SetControlsState()
        {
            bAddTopTopic.Enabled = true;
            bAddSubTopic.Enabled = (tvTopics.SelectedNode != null);
            bDeleteTopic.Enabled = (tvTopics.SelectedNode != null);
            bTopicProperties.Enabled = (tvTopics.SelectedNode != null);
        }

        /// <summary>
        /// Adds new topic under the parent node.
        /// </summary>
        /// <param name="perentNode">Parent node.</param>
        private void AddNewTopic(TreeNode perentNode = null)
        {
            ShowTopicPropertiesForm(CreateNewTopic(),
                formTitle: perentNode == null ? "Add new top level topic..." : "Add new topic...",
                beforeSave: topic =>
                {
                    // Create new tree node.
                    TreeNode newTopicNode = new TreeNode();
                    newTopicNode.Tag = topic;
                    newTopicNode.Text = topic.Title;
                    newTopicNode.ToolTipText = topic.Tooltip;

                    // Insert new topic.
                    if (perentNode == null)
                    {
                        topic.ParentId = null;
                        tvTopics.Nodes.Add(newTopicNode);

                        AdviserStorage.Current.Topics.Add(topic);
                    }
                    else
                    {
                        Topic parentTopic = (Topic)perentNode.Tag;
                        topic.Parent = parentTopic;
                        parentTopic.SubTopics.Add(topic);
                        perentNode.Nodes.Add(newTopicNode);

                        SortTopics(perentNode.Nodes);
                    }
                });

            SetControlsState();
        }

        /// <summary>
        /// Creates new empty topic.
        /// </summary>
        private Topic CreateNewTopic()
        {
            return new Topic
            {
                Text = new Text()
            };
        }

        /// <summary>
        /// Deletes selected topic.
        /// </summary>
        public void DeleteTopic()
        {
            if (tvTopics.SelectedNode == null)
                return;

            TreeNode selectedNode = tvTopics.SelectedNode;
            Topic topic = (Topic)selectedNode.Tag;

            if (MessageBox.Show(Form.ActiveForm, String.Format(Resources.DeleteTopicConfirmation, topic.Title), Resources.Confirmation, MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (selectedNode.Parent == null)
            { tvTopics.Nodes.Remove(selectedNode); }
            else
            { selectedNode.Parent.Nodes.Remove(selectedNode); }

            AdviserStorage.Current.Topics.Remove(topic);
            
            AdviserStorage.Current.SaveChanges();

            SetControlsState();

            OnSelectedTopicChanged();
        }

        /// <summary>
        /// Sort nodes.
        /// </summary>
        /// <param name="nodesCollection">Collection of nodes.</param>
        private void SortTopics(TreeNodeCollection nodesCollection)
        {
            if (nodesCollection == null)
                return;
            if (nodesCollection.Count <= 1)
                return;

            var nodes = nodesCollection.Cast<TreeNode>().OrderBy(n => n.Text).ToArray();

            nodesCollection.Clear();
            nodesCollection.AddRange(nodes);
        }

        /// <summary>
        /// Raises SelectedTopicChanged event.
        /// </summary>
        protected virtual void OnSelectedTopicChanged()
        {
            if (SelectedTopicChanged != null)
                SelectedTopicChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Shows topic properties.
        /// </summary>
        public void ShowTopicProperties()
        {
            TreeNode selNode = tvTopics.SelectedNode;
            if (selNode == null)
                return;
            Debug.Assert(selNode.Tag != null);
            Debug.Assert(selNode.Tag is Topic);

            ShowTopicPropertiesForm((Topic)selNode.Tag, beforeSave: topic =>
            {
                selNode.Text = topic.Title;
                selNode.ToolTipText = topic.Tooltip;
            });
        }

        /// <summary>
        /// Shows form of topic properties.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <param name="formTitle">Title of the form.</param>
        /// <param name="beforeSave">Action to do before saving changes.</param>
        private void ShowTopicPropertiesForm(Topic topic, string formTitle = null, Action<Topic> beforeSave = null)
        {
            TopicPropertiesForm frm = new TopicPropertiesForm();
            if (formTitle != null)
            {
                frm.Text = formTitle;
            }
            frm.Topic = topic;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (beforeSave != null)
                {
                    beforeSave(topic);
                }
                
                AdviserStorage.Current.SaveChanges();

                OnSelectedTopicChanged();
            }
        }

        /// <summary>
        /// Expands topics with given ids.
        /// </summary>
        /// <param name="topicIds">Topics ids.</param>
        /// <returns>Last expanded node.</returns>
        public TreeNode ExpandTopics(long[] topicIds)
        {
            var listOfNodes = tvTopics.Nodes;
            TreeNode lastExpandedNode = null;

            foreach (var topicId in topicIds)
            {
                lastExpandedNode = GetTopicNode(listOfNodes, topicId);
                if (lastExpandedNode == null)
                { return null; }

                lastExpandedNode.Expand();
                listOfNodes = lastExpandedNode.Nodes;
            }

            return lastExpandedNode;
        }

        /// <summary>
        /// Gets tree node for topic with given id.
        /// </summary>
        /// <param name="nodes">Nodes collection.</param>
        /// <param name="topicId">Topic id.</param>
        private TreeNode GetTopicNode(TreeNodeCollection nodes, long topicId)
        {
            return nodes.OfType<TreeNode>().FirstOrDefault(n => ((Topic)n.Tag).Id == topicId);
        }

        /// <summary>
        /// Selects topic with given id.
        /// </summary>
        /// <param name="nodes">Collection of nodes.</param>
        /// <param name="topicId">Topic id.</param>
        public void SelectTopic(TreeNodeCollection nodes, long topicId)
        {
            tvTopics.SelectedNode = GetTopicNode(nodes, topicId);
        }
    }
}
