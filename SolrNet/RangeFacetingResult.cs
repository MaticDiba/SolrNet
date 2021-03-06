﻿#region license
// Copyright (c) 2007-2010 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections.Generic;
using System;

namespace SolrNet {
    /// <summary>
    /// Range faceting result
    /// </summary>
    public class RangeFacetingResult {

		/// <summary>
		/// Range range gap (e.g. "+1DAY")
		/// </summary>
        public string Gap { get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        public string End { get; set; }

        public string Start { get; set; }

        /// <summary>
        /// The date faceting results.
        /// </summary>
        public IList<KeyValuePair<string, int>> RangeResults { get; set; } = new List<KeyValuePair<string, int>>();

        /// <summary>
        /// Other date faceting results.
        /// </summary>
        public IDictionary<FacetRangeOther, int> OtherResults { get; set; } = new Dictionary<FacetRangeOther, int>();
       
    }
}