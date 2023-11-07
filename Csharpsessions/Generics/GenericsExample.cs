/*using System.Collections.ObjectModel;
using System.Reflection.PortableExecutable;

namespace Csharpsessions.Generics
{
    internal class GenericsExample
    {
        internal static void Run()
        {
            DataStore<string> stringDataStore = new("some data");
            DataStore<int> intDataStore = new(5);

            stringDataStore.PrintData();
            intDataStore.PrintData();

            List<int> listOfIntegers = new();

            AnimalStorage<Cat> catStorage;
            AnimalStorage<Dog> dogStorage;
            AnimalStorage<string> stringStorage; // string is not an animal

            *//*catStorage.PrintData();
            dogStorage.PrintData();
            stringStorage.PrintData();*//*

            Dog dog = new();
            void Pet(Animal animal) { *//*pet the animal*//* }
            Pet(dog); // we're putting in a more derived type -> covariance

            Animal animal;
            Dog GetDog() => new Dog(); *//*gets a dog*//*
            animal = GetDog(); // we're outputting to a more generic type -> contravariance

            
            animal;

            GenericMethodExample genericMethodExample = new();
            genericMethodExample.GenericMethod(5f);
        }
    }

    internal class DataStore<T>
    {
        T Data { get; set; }

        internal DataStore(T Data)
        {
            this.Data = Data;
        }

        internal void PrintData()
        {
            Console.WriteLine(Data);
        }

        internal void ReplaceData(T newData)
        {
            Data = newData;
        }
    }

    /// <summary>
    /// The reason you don't just create an AnimalStorage with an Animal property
    /// of type Animal, is than there'd be no way of ensuring your AnimalStorage<Dog>
    /// won't contain a cat.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class AnimalStorage<T> where T : Animal
    {
        T Animal { get; set; }

        internal AnimalStorage(T Data)
        {
            this.Animal = Data;
        }

        internal void PrintData()
        {
            Console.WriteLine(Animal);
        }

        internal void ReplaceData(T newData)
        {
            Animal = newData;
        }
    }

    internal interface IPetter<in T> where T : Animal
    {

    }

    internal interface IGetter<out T> where T : Animal
    {

    }

    internal class GenericMethodExample
    {
        public T GenericMethod<T>(T inputParameter)
        {
            // do something
            return inputParameter;
        }
    }

    internal class CoAndContravarianceExample
    {
        public void ConvertExample()
        {
            // Covariance
            string[] stringArray = new string[1];
            object[] objectArray = stringArray;

            objectArray = new object[1];
            stringArray = objectArray; // not allowed

            // Covariance
            IReadOnlyList<string> stringReadonlyList = new List<string>();
            IReadOnlyList<object> objectReadonlyList = stringReadonlyList;

            objectReadonlyList = new List<object>();
            stringReadonlyList = objectReadonlyList; // not allowed

            // Contravariance 


            ObjectAction("some string of some sort");
            objectAction.Invoke("some string of some sort");

            void StringAction(string str) { } // method with void return
            //Action<string> stringAction = StringAction; // stored as an action

            // these both do the same thing
            StringAction("do something with this string"); 
            stringAction.Invoke("do something with this string");

            void ObjectAction(object obj) { }
            //Action<object> objectAction = ObjectAction;

            objectAction.Invoke("a string is an object so this is fine");

            // Contravariance 
            Action<string> stringAction = ObjectAction;
            Action<object> objectAction = StringAction; // not allowed



            IEatingMachine<object> objectEatingMachine = new ObjectEatingMachine();
            IEatingMachine<string> stringEatingMachine = objectEatingMachine;

            IMakingMachine<string> stringMakingMachine = new StringMakingMachine();
            IMakingMachine<object> objectMakingMachine = stringMakingMachine;
        }

        interface IEatingMachine<in T>
        {

        }

        interface IMakingMachine<out T>
        {

        }

        class ObjectEatingMachine: IEatingMachine<object> { }
        class StringMakingMachine: IMakingMachine<string> { }

    }
}
*/