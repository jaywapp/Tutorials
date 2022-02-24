using IoC.Model;
using System;
using System.Collections.Generic;
using Unity;
using Unity.Lifetime;

namespace IoC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test5();
        }

        private static void Test1()
        {
            // container 생성
            var container = new UnityContainer();

            // 1. Job 생성
            var singer = new Job() { Name = "Singer", };

            // 2. Job Instance를 container에 등록
            container.RegisterInstance(singer);
            
            // 3. container를 통해 Person Instance Resolve
            var person = container.Resolve<Person>();

            // 4. person의 Job 프로퍼티 확인
            Console.WriteLine(person.Job.ToString());

            // 대기를 위한 ReadLine 함수
            Console.ReadLine();
        }

        private static void Test2()
        {
            // container 생성
            var container = new UnityContainer();

            // 1. Job 생성
            var singer = new Job() { Name = "Singer", };

            // 2. Job Instance를 container에 등록
            container.RegisterInstance(singer);

            var persons = new List<Person>();

            for(int i = 0; i<10; i ++)
            {
                // 3. container를 통해 Person Instance Resolve
                var person = container.Resolve<Person>();
                persons.Add(person);
            }

            for (int i = 0; i < 10; i++)
            {
                // 4. person의 Job 프로퍼티 및 Instance 정보 확인
                var person = persons[i];
                Console.WriteLine($"[{i}] {person} (person instance : {person.GetHashCode()}, job instance : {person.Job.GetHashCode()})");
            }

            // 대기를 위한 ReadLine 함수
            Console.ReadLine();
        }

        private static void Test3()
        {
            // container 생성
            var container = new UnityContainer();
            var persons = new List<ShufflePerson>();

            for (int i = 0; i < 10; i++)
            {
                // container를 통해 Person Instance Resolve
                var person = container.Resolve<ShufflePerson>();
                persons.Add(person);
            }

            for (int i = 0; i < 10; i++)
            {
                // person의 Job 프로퍼티 및 Instance 정보 확인
                var person = persons[i];
                Console.WriteLine($"[{i}] {person} (person instance : {person.GetHashCode()}, job instance : {person.Job.GetHashCode()})");
            }

            // 대기를 위한 ReadLine 함수
            Console.ReadLine();
        }

        private static void Test4()
        {
            // container 생성
            var container = new UnityContainer();

            // 2. Job Type을 container에 등록
            container.RegisterType<Job, ShuffleJob>();

            var persons = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                // 3. container를 통해 Person Instance Resolve
                var person = container.Resolve<Person>();
                persons.Add(person);
            }

            for (int i = 0; i < 10; i++)
            {
                // 4. person의 Job 프로퍼티 및 Instance 정보 확인
                var person = persons[i];
                Console.WriteLine($"[{i}] {person} (person instance : {person.GetHashCode()}, job instance : {person.Job.GetHashCode()})");
            }

            // 대기를 위한 ReadLine 함수
            Console.ReadLine();
        }

        private static void Test5()
        {
            // container 생성
            var container = new UnityContainer();

            // 2. Job Type을 container에 등록
            container.RegisterType<Job, ShuffleJob>(new ContainerControlledLifetimeManager());

            var persons = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                // 3. container를 통해 Person Instance Resolve
                var person = container.Resolve<Person>();
                persons.Add(person);
            }

            for (int i = 0; i < 10; i++)
            {
                // 4. person의 Job 프로퍼티 및 Instance 정보 확인
                var person = persons[i];
                Console.WriteLine($"[{i}] {person} (person instance : {person.GetHashCode()}, job instance : {person.Job.GetHashCode()})");
            }

            // 대기를 위한 ReadLine 함수
            Console.ReadLine();
        }
    }
}
