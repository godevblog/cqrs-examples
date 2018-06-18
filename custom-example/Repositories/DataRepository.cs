using System;
using System.Collections.Concurrent;

namespace CustomExample.Repositories {
    public class DataRepository {
        private ConcurrentDictionary<string, string> _data;

        public DataRepository() {
            _data = new ConcurrentDictionary<string, string>();
        }

        public string Get(string key) {
            var value = string.Empty;

            _data.TryGetValue(key, out value);

            return value;
        }

        public void Set(string key, string value) {
            _data.TryAdd(key, value);
        }

        internal void Delete(string key) {
            var value = string.Empty;
            _data.TryRemove(key, out value);
        }
    }
}