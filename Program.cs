using project_65030034;
namespace Project_65030034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project members:");
            foreach (string member in Enum.GetNames(typeof(Project.Members)))
            {
                Console.WriteLine("  [" +
                    ((int)Enum.Parse(typeof(Project.Members), member)).ToString() + "]: "
                    + member);
            }

            Console.WriteLine($"Project members count = {Enum.GetNames(typeof(Project.Members)).Length == 4 }");
            public void TestProjectMemberIds()
            {
                 Assert.IsTrue((int)Project.Members.Silla == 1);
                 Assert.IsTrue((int)Project.Members.Moke == 2);
                 Assert.IsTrue((int)Project.Members.Saitong == 3);
                 Assert.IsTrue((int)Project.Members.Nainoy == 4);
            }

        }
    }
}
