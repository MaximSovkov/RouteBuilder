using System.Collections.Generic;
using System.Linq;

namespace RouteBuilder
{
    /// <summary>
    /// Route builder.
    /// </summary>
    public class RouteBuilder
    {
        /// <summary>
        /// Build a route based on input paths.
        /// </summary>
        /// <param name="paths">Paths.</param>
        public string BuildRoute(List<Path> paths)
        {
            // Sort paths by the logical route.
            for (var i = 0; i < paths.Count; i++)
            {
                for (var j = 0; j < paths.Count; j++)
                {
                    if (paths[i].From == paths[j].To && j > i)
                    {
                        var temp = paths[i];
                        paths[i] = paths[j];
                        paths[j] = temp;
                    }
                }
            }

            // Collect the output array by taking the "From" field from all elements,
            // and the "From" and "To" fields from the last element.
            var result = paths.Select((path, index) =>
            {
                if (index == paths.Count - 1)
                {
                    return $"{path.From} - {path.To}";
                }

                return path.From;
            });

            // Combine the output array into a separate line representing the route.
            return string.Join(" - ", result);
        }
    }
}
