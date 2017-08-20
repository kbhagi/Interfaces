using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    using System;

    interface ITitled
    {
        string Title { get; }
    }

    interface IExample
    {
        void SomeMethod();
    }

    class Person : ITitled, IExample
    {
   
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public virtual string Title
        {
            get
            {
                return "";
            }
        }
        public override string ToString()
        {
        if (string.IsNullOrWhiteSpace(Title))
            return Name;
        else
            return $"{Title} {Name}";
        }
    void IExample.SomeMethod()
    {
    }
    void M()
    {
        this.SomeMethod();
        IExample example = this;
        example.SomeMethod();
    }
    }

sealed class President : Person,IExample
{
    public President(string name) : base(name)
    {

    }
    public override string Title
    {
        get
        {
            return "President";
        }
    }
}
abstract class ChangeRequest : ITitled
{
    protected ChangeRequest(string title, Person implementer)
    {
        Title = title;
        Implementer = implementer;
    }
        public string Title { get; set; }
    public Person Implementer { get; set; }

    public void SubmitRequest()
    {
        ValidateRequest();
    }







    }
}

