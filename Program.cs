namespace CSVToFixedWidth
{
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
           string input = args.ToList().First() ?? string.Empty;
		   string output = args.ToList().Last() ?? string.Empty;
			if(File.Exists(input)){
				List<string> lines =  File.ReadAllLines(input).ToList();
				StringBuilder sb = new StringBuilder();

				foreach(string line in lines){
					List<string> segments = line.Split(",").ToList();
					string newLine = string.Empty;
					
					foreach(string str in segments){
						newLine += str.Trim().PadRight(9, ' ' );
					}

					sb.AppendLine(newLine);					
				}
				 File.WriteAllText(output, sb.ToString());
				
			}
			else{
				Console.WriteLine("Input file could not be found!");
			}
        }
    }
}