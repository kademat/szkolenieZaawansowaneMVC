﻿using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = Builder<User>.CreateListOfSize(10)
                .All()
                .With(u => u.Name = Faker.NameFaker.Name())
                .With(u => u.Email = Faker.InternetFaker.Email())
                .Build();

            foreach (var user in users)
            {
                Console.WriteLine("{0} {1}", user.Name, user.Email);
            }

            //var user = new User()
            //{
            //    Name = Faker.NameFaker.FirstName(),
            //    Email = Faker.InternetFaker.Email()
            //};

            //Console.WriteLine("{0} {1}", user.Name, user.Email);

            Console.ReadLine();
        }
    }
}
