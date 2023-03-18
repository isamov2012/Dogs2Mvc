namespace Dogs2Mvc.Models
{
	public class DataService
	{
		List<Dog> dogs = new List<Dog>
		{
			new Dog{Id=1, Name="Char",Age=2},
			new Dog{Id=2, Name="Walter",Age=1},
			new Dog{Id=3, Name="Petya",Age=3},
			new Dog{Id=4, Name="SnowF",Age=5},
		};
		public void AddDog(Dog dog)
		{
			dog.Id=dogs.Max(x => x.Id)+1;
			dogs.Add(dog);
		}

		public Dog[] GetAll()
		{
			return dogs.ToArray();
		}

		public Dog FindById(int id)
		{
			return dogs
				.SingleOrDefault(d => d.Id==id);
		}

		public void Update(int id,Dog newDog)
		{
			var dog = FindById(id);
			dog.Name = newDog.Name;
			dog.Age = newDog.Age;
		}
	}
}
