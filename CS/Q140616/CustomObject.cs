using System.ComponentModel;
namespace DXSample {
    public class CustomObject {
        public CustomObject(string name, string password) {
            this.Name = name;
            this.password = password;
        }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string password;
        [PasswordPropertyTextAttribute(true)]
        public string Password {
            get { return password; }
            set { password = value; }
        }
    }
}