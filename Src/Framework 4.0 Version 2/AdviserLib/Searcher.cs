//------------------------------------------------------------------------------
// Copyright: (c) 2006/2007 Edlin Software, Russia
//------------------------------------------------------------------------------
// $Source$
// Unit:        Adviser\Src\AdviserLib\Objects
// Author:      Ivan_Yakimov
// Responsible: Ivan_Yakimov
//------------------------------------------------------------------------------
// Description: Class for searching of topics.
//------------------------------------------------------------------------------
// $Log$
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using EdlinSoftware.Adviser.Repository;

namespace EdlinSoftware.Adviser
{
	/// <summary>
	/// Class for searching of topics.
	/// </summary>
	public class Searcher
	{
		/// <summary>
		/// Returns array of topics where text was found.
		/// </summary>
		/// <param name="searchText">Text to search.</param>
		/// <returns>Array of topics where text was found.</returns>
		public static Topic[] GetTopics(string searchText )
		{
			if( string.IsNullOrEmpty( searchText ) )
				return new Topic[ 0 ];

			string[] searchParts = searchText.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );

			try
			{
                var topicIds = GetTopicIds(searchParts);

                return AdviserStorage.Current.Topics
                    .Where(t => topicIds.Contains(t.Id))
                    .ToArray();
			}
			catch
			{ return new Topic[ 0 ]; }
		}

        private static IEnumerable<long> GetTopicIds(string[] searchParts)
        {
            var sqlQueryText = string.Format("SELECT DISTINCT [Id] FROM [Texts] WHERE {0}",
                string.Join(" AND ", searchParts.Select(word => string.Format("[PlainText] LIKE '%{0}%'", word))));

            var textIds = AdviserStorage.Current.Database.SqlQuery<long>(sqlQueryText);

            sqlQueryText = string.Format("SELECT DISTINCT [Id] FROM [Topics] WHERE ({0}) OR ({1})",
                string.Join(" AND ", searchParts.Select(word => string.Format("[Title] LIKE '%{0}%'", word))),
                string.Join(" AND ", searchParts.Select(word => string.Format("[Tooltip] LIKE '%{0}%'", word))));

            var topicIds = AdviserStorage.Current.Database.SqlQuery<long>(sqlQueryText);

            return GetTopicIdsByTextIds(textIds.ToArray()).Union(topicIds).Distinct();
        }

        private static IEnumerable<long> GetTopicIdsByTextIds(long[] textIds)
        {
            return AdviserStorage.Current.Topics
                .Where(t => textIds.Contains(t.TextId))
                .Select(t => t.Id)
                .Concat(AdviserStorage.Current.Codes
                .Where(cp => textIds.Contains(cp.TextId)).
                Select(cp => cp.TopicId))
                .Distinct();
        }

        /// <summary>
        /// Gets ids of all parent topics ordered from topmost.
        /// </summary>
        /// <param name="topicId">Topic id.</param>
        public static long[] GetParentTopics(long topicId)
        {
            var parentIds = new List<long>();

            while (true)
            {
                var parentId = AdviserStorage.Current.Topics.Where(t => t.Id == topicId).Select(t => t.ParentId).First();
                if (parentId.HasValue == false)
                    break;

                topicId = parentId.Value;
                parentIds.Insert(0, topicId);
            }

            return parentIds.ToArray();
        }
    }
}
