using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.IO;
using System;

namespace SimpleJsonConfig
{
    public class Config
    {
        private readonly Dictionary<string, JsonElement> _values;

        public Config(string path)
        {
            var json = File.ReadAllText(path);
            using var doc = JsonDocument.Parse(json);
            _values = doc.RootElement.EnumerateObject()
                .ToDictionary(p => p.Name, p => p.Value.Clone(), StringComparer.OrdinalIgnoreCase);

        }

        public string? GetString(string key) =>
            _values.TryGetValue(key, out var val) && val.ValueKind == JsonValueKind.String
                ? val.GetString()
                : null;

        public int? GetInt(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetInt32(out var i))
                return i;

            return null;
        }

        public bool? GetBool(string key)
        {
            if (_values.TryGetValue(key, out var val) &&
                (val.ValueKind == JsonValueKind.True || val.ValueKind == JsonValueKind.False))
            {
                return val.GetBoolean();
            }
            return null;
        }

        public double? GetDouble(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetDouble(out var d))
                return d;

            return null;
        }

        public DateTime? GetDateTime(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetDateTime(out var dt))
                return dt;

            return null;
        }

        public long? GetLong(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetInt64(out var l))
                return l;

            return null;
        }

        public float? GetFloat(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetSingle(out var f))
                return f;

            return null;
        }

        public decimal? GetDecimal(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetDecimal(out var d))
                return d;

            return null;
        }

        public Guid? GetGuid(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetGuid(out var g))
                return g;

            return null;
        }

        // Optional cast-from-int entries:
        public short? GetShort(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetInt32(out var i))
                return (short)i;

            return null;
        }

        public byte? GetByte(string key)
        {
            if (_values.TryGetValue(key, out var val) && val.TryGetInt32(out var i))
                return (byte)i;

            return null;
        }
    }
}
