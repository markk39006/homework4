using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = Console.ReadLine();
            char yesorno;
            int j = 1;
            IsValidSequence(dna);
            if (IsValidSequence(dna) == true)
            {
                Console.WriteLine("Current half DNA sequence :" + dna);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                yesorno = char.Parse(Console.ReadLine());
                if (yesorno == 'Y')
                {
                    Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(dna));
                }
                else if (yesorno == 'N')
                {

                }
                else
                {
                    for (bool i = true; i == true; j++)
                    {
                        Console.Write("Please input Y or N : ");
                        yesorno = char.Parse(Console.ReadLine());
                        if (yesorno == 'Y')
                        {
                            i = false;
                            Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(dna));
                        }
                        else if (yesorno == 'N')
                        {
                            i = false;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            for (bool k = true; k == true; j++)
            {
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                yesorno = char.Parse(Console.ReadLine());
                if (yesorno == 'Y')
                {
                    two();
                }
                else if (yesorno == 'N')
                {
                    k = false;
                }
                else
                {
                    for (bool i = true; i == true; j++)
                    {
                        Console.Write("Please input Y or N : ");
                        yesorno = char.Parse(Console.ReadLine());
                        if (yesorno == 'Y')
                        {
                            i = false;
                            Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(dna));
                        }
                        else if (yesorno == 'N')
                        {
                            i = false;
                            k = false;
                        }
                    }
                }

            }
            //Console.ReadLine();

        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static void two()
        {
            string dna = Console.ReadLine();
            char yesorno;
            int j = 1;
            IsValidSequence(dna);
            if (IsValidSequence(dna) == true)
            {
                Console.WriteLine("Current half DNA sequence :" + dna);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                yesorno = char.Parse(Console.ReadLine());
                if (yesorno == 'Y')
                {
                    Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(dna));
                }
                else if (yesorno == 'N')
                {

                }
                else
                {
                    for (bool i = true; i == true; j++)
                    {
                        Console.Write("Please input Y or N : ");
                        yesorno = char.Parse(Console.ReadLine());
                        if (yesorno == 'Y')
                        {
                            i = false;
                            Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(dna));
                        }
                        else if (yesorno == 'N')
                        {
                            i = false;

                        }
                    }
                }
            }
        }
    }
}
