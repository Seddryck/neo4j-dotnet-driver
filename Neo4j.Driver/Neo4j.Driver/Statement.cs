﻿//  Copyright (c) 2002-2016 "Neo Technology,"
//  Network Engine for Objects in Lund AB [http://neotechnology.com]
// 
//  This file is part of Neo4j.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
using System.Collections.Generic;
using Neo4j.Driver.Extensions;

namespace Neo4j.Driver
{
    /// <summary>
    /// An executable statement, i.e. the statements' text and its parameters.
    /// </summary>
    public class Statement
    {
        /// <summary>
        /// Gets the statement's template.
        /// </summary>
        public string Template { get; }
        /// <summary>
        /// Gets the statement's parameters.
        /// </summary>
        public IReadOnlyDictionary<string, object> Parameters { get; }

        /// <summary>
        /// Create a statemete
        /// </summary>
        /// <param name="template">The statement's template</param>
        /// <param name="parameters">The statement's parameters</param>
        public Statement(string template, IDictionary<string, object> parameters = null)
        {
            Template = template;
            Parameters = parameters == null ? new Dictionary<string, object>() : new Dictionary<string, object>(parameters);
        }

        public override string ToString()
        {
            return $"`{Template}`, {Parameters.ToContentString()}";
        }
    }

}