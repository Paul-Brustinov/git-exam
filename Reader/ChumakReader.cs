using System.Collections.Generic;
using System.IO;
using git_exam.Person;
using YamlDotNet.Serialization;

namespace git_exam.Reader {
    public class ChumakReader : AbstractGetter<List<Hooman>> {
        private const string Path = "../../chumak.yml";

        public override List<Hooman> Get()
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<List<Hooman>>(File.ReadAllText(Path));
        }
    }
}