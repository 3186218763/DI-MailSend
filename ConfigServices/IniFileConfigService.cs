using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConfigServices
{
    public class IniFileConfigService:IConfigService
    {
        public string? FilePath { get; set; }

        public string GetValue(string name)
        {
            var kv = File.ReadAllLines(FilePath).Select(strs => new { Name = strs.Split('=')[0], Value = strs.Split('=')[1] }).SingleOrDefault(kv =>kv.Name==name);
            if (kv != null)
            {
                return kv.Value;
            }
            else
            {
                return null;
            }
        }
    }
}