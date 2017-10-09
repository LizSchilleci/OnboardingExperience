namespace OnboardingApp
{
	public class User
	{
		internal readonly string FullName;

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsAccountOwner { get; set; }
		public string PinNumber { get; set; }


		public User()
		{
		}
	}
}