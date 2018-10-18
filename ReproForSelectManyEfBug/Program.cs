using System;
using System.Linq;

namespace ReproForSelectManyEfBug
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ReproDbContext())
            {
                var childrenNames =
                    context.Parents
                    .SelectMany(parent => parent.Children.Select(child => new
                    {
                        ParentName = parent.Name,
                        ChildName = child.Name
                    }));

                var results = childrenNames.ToArray();
            }
        }
    }
}
