﻿/*
MIT License

Copyright (c) Léo Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LABS_Experiences.Forms;

public partial class LABS_XML : LABSForm
{
    public LABS_XML()
    {
        InitializeComponent();
        Init();
    }

    List<Person> people = new();
    Person p = new() { Name = "Jean", Age = 32 };
    Person p1 = new() { Name = "Pierre", Age = 22 };

    public void Init()
    {
        people.Add(p);
        people.Add(p1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Text = string.Empty;
        XmlSerializer xmlSerializer = new(people.GetType());
        StreamWriter streamWriter = new(Application.StartupPath + @"\test.labs");
        xmlSerializer.Serialize(streamWriter, people);
        streamWriter.Dispose();
        textBox1.Text = new StreamReader(Application.StartupPath + @"\test.labs").ReadToEnd();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = string.Empty;
        XmlSerializer xmlSerializer = new(people.GetType());
        StreamReader streamReader = new(Application.StartupPath + @"\test.labs");
        List<Person> deserializedPeople = new();
        deserializedPeople = (List<Person>)xmlSerializer.Deserialize(streamReader);

        foreach (Person person in deserializedPeople)
        {
            textBox1.Text += person.Name + Environment.NewLine;
            textBox1.Text += person.Age + Environment.NewLine;
        }

        streamReader.Dispose();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Dictionary<Person, int> keyValuePairs = new();

        Person person = new() { Age = 14, Name = "Léo" };
        Person person1 = new() { Age = 34, Name = "Jean" };
        Person person2 = new() { Age = 24, Name = "Pierre" };

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
