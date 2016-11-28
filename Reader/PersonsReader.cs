using System.IO;
using git_exam.Person;
using YamlDotNet.Serialization;

namespace git_exam.Reader {
    public class PersonsReader {
        private const string Path = "../../persons.yml";

        public static Hooman Get()
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<Hooman>(File.ReadAllText(Path));
        }
    }
}