
using CsPractice.DataStructures;

namespace CsPractice.Problems.StacksAndQueues
{
    public class AnimalShelterQueue
    {
        SingleLinkNode<Animal> oldestCat;
        SingleLinkNode<Animal> newestCat;
        SingleLinkNode<Animal> oldestDog;
        SingleLinkNode<Animal> newestDog;

        public void Enqueue(int time, bool isCat, string name)
        {
            SingleLinkNode<Animal> animalToEnqueue = new SingleLinkNode<Animal>(new Animal(time, isCat, name));
            if (isCat)
            {
                if (oldestCat == null)
                {
                    oldestCat = animalToEnqueue;
                    newestCat = animalToEnqueue;
                }
                else
                {
                    newestCat.Next = animalToEnqueue;
                    newestCat = newestCat.Next;
                }
            }
            else
            {
                if (oldestDog == null)
                {
                    oldestDog = animalToEnqueue;
                    newestDog = animalToEnqueue;
                }
                else
                {
                    newestDog.Next = animalToEnqueue;
                    newestDog = newestDog.Next;
                }
            }
        }

        public Animal DequeueAny()
        {
            if (oldestCat == null && oldestDog == null)
            {
                throw new EmptyQueueException();
            }
            else if (oldestDog == null)
            {
                return DequeueSpecific(true);
            }
            else if (oldestCat == null)
            {
                return DequeueSpecific(false);
            }
            else
            {
                if (oldestCat.Data.TimeOfArrival <= oldestDog.Data.TimeOfArrival)
                {
                    return DequeueSpecific(true);
                }
                else
                {
                    return DequeueSpecific(false);
                }
            }
        }

        public Animal DequeueSpecific(bool isCat)
        {
            if (isCat)
            {
                if (oldestCat == null)
                {
                    throw new EmptyQueueException();
                }

                Animal animalToAdopt = oldestCat.Data;
                oldestCat = oldestCat.Next;
                if (oldestCat == null)
                {
                    newestCat = null;
                }
                return animalToAdopt;
            }
            else
            {
                if (oldestDog == null)
                {
                    throw new EmptyQueueException();
                }

                Animal animalToAdopt = oldestDog.Data;
                oldestDog = oldestDog.Next;
                if (oldestDog == null)
                {
                    newestDog = null;
                }
                return animalToAdopt;
            }
        }
    }

    public class Animal
    {
        public int TimeOfArrival { get; private set; }
        public bool IsCat { get; private set; }
        public string Name { get; private set; }

        public Animal(int time, bool cat, string name)
        {
            TimeOfArrival = time;
            IsCat = cat;
            Name = name;
        }
    }
}
