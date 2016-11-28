using System.IO;
using git_exam.Person;
using YamlDotNet.Serialization;

namespace git_exam.Reader {
    public class ChumakReader {
        private const string Path = "../../chumak.yml";

        public static Hooman Get()
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<Hooman>(File.ReadAllText(Path));
        }
    }
}