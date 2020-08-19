using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LABS_Experiences.Forms
{

    public partial class LABS_XML : LABSForm
    {
        public LABS_XML()
        {
            InitializeComponent();
            Init();
        }

        List<Person> people = new List<Person>();
        Person p = new Person { Name = "Jean", Age = 32 };
        Person p1 = new Person { Name = "Pierre", Age = 22 };

        public void Init()
        {
            people.Add(p);
            people.Add(p1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            XmlSerializer xmlSerializer = new XmlSerializer(people.GetType());
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"\test.labs");
            xmlSerializer.Serialize(streamWriter, people);
            streamWriter.Dispose();
            textBox1.Text = new StreamReader(Application.StartupPath + @"\test.labs").ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            XmlSerializer xmlSerializer = new XmlSerializer(people.GetType());
            StreamReader streamReader = new StreamReader(Application.StartupPath + @"\test.labs");
            List<Person> deserializedPeople = new List<Person>();
            deserializedPeople = (List<Person>) xmlSerializer.Deserialize(streamReader);

            foreach (Person person in deserializedPeople)
            {
                textBox1.Text += person.Name + Environment.NewLine;
                textBox1.Text += person.Age + Environment.NewLine;
            }

            streamReader.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<Person, int> keyValuePairs = new Dictionary<Person, int>();
            
            Person person = new Person { Age = 14, Name = "Léo" };
            Person person1 = new Person { Age = 34, Name = "Jean" };
            Person person2 = new Person { Age = 24, Name = "Pierre" };

            keyValuePairs.Add(person, person.Age);
            keyValuePairs.Add(person1, person1.Age);
            keyValuePairs.Add(person2, person2.Age);

            var items = from pair in keyValuePairs orderby pair.Value descending select pair;
            textBox1.Text = "";

            foreach (KeyValuePair<Person, int> pair in items)
            {
                textBox1.Text += $"{pair.Key} : {pair.Value} \r\n";
            }
        }
    }

    public class Person
    {
        public string Name;
        public int Age;
    }
}
