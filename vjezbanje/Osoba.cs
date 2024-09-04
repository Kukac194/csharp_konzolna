using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbanje
{
    class Osoba
    {
        private int _id;
        private String firstName;
        private String lastName;
        private int age;
        private String city;
        private String country;
        private String phone;
        private String email;

        //Konstruktor bez parametara
        public Osoba()
        {

        }

        //Konstruktor sa parametrima - ovo je konstructor overloading
        public Osoba(int _id, String firstName, String lastName, int age, String city, String country, String phone, String email)
        {
            this._id = _id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.email = email;
        }

        //Getteri
        public int getId() { return _id; }
        public String getFirstName() { return firstName; }
        public String getLastName() { return lastName; }
        public int getAge() { return age; }

        public String getCity() { return city; }
        public String getCountry() { return country; }
        public String getPhone() { return phone; }
        public String getEmail() { return email; }


        //Setteri
        public void setId(int id) { _id = id; }
        public void setFirstName(String firstName) { this.firstName = firstName; } 
        public void setLastName(String lastName) { this.lastName = lastName; }
        public void setAge(int age) { this.age = age; }
        public void setCity(String city) { this.city = city; }
        public void setCountry(String country) { this.country = country; }
        public void setPhone(String phone) { this.phone = phone; }
        public void setEmail(String email) { this.email = email; }

    }
}
