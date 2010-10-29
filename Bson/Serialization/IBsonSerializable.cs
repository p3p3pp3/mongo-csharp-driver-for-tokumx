﻿/* Copyright 2010 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson.IO;

namespace MongoDB.Bson.Serialization {
    public interface IBsonSerializable {
        // DeserializeDocument and DeserializeElement can return a new object (i.e. a subclass of nominalType) or even null
        object DeserializeDocument(BsonReader bsonReader, Type nominalType);
        object DeserializeElement(BsonReader bsonReader, Type nominalType, out string name);
        bool DocumentHasIdMember();
        bool DocumentHasIdValue(out object existingId);
        void GenerateDocumentId();
        void SerializeDocument(BsonWriter bsonWriter, Type nominalType, bool serializeIdFirst);
        void SerializeElement(BsonWriter bsonWriter, Type nominalType, string name);
    }
}
