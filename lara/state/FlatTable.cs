﻿using System.Collections.Generic;

namespace nora.lara.state {

    public class FlatTable {

        public static FlatTable CreateWith(
                string name, 
                bool needsDecoder, 
                List<PropertyInfo> properties) {
            return new FlatTable {
                NetTableName = name,
                NeedsDecoder = needsDecoder,
                Properties = properties
            };
        }

        public string NetTableName { get; private set; }
        public bool NeedsDecoder { get; private set; }
        public List<PropertyInfo> Properties { get; private set; }
    }
}
