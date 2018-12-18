using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Premier
    {
        public string name, range, constituent, birth, death, party;

        public Premier(string name, string range, string constituent, string birth, string death, string party)
        {
            this.name = name;
            this.range = range;
            this.constituent = constituent;
            this.birth = birth;
            this.death = death;
            this.party = party;
        }

        public string GetKey()
        {
            string[] names = name.Split();
            return names[names.Length - 1];
        }

        public static List<Premier> GetPremiers()
        {
            List<Premier> premiers = new List<Premier>();
            premiers.Add(new Premier("John Sandfield Macdonald", "(1812-1872)", "MLA for Cornwall", "16 July 1867", "20 December 1871", "Liberal-Conservative Party"));
            premiers.Add(new Premier("Edward Blake", "(1833-1912)", "MLA for Bruce South", "20 December 1871", "25 October 1872", "Liberal Party"));
            premiers.Add(new Premier("Sir Oliver Mowat", "(1820-1903)", "MLA for Oxford North", "25 October 1872", "21 July 1896", "Liberal Party"));
            premiers.Add(new Premier("Arthur Sturgis Hardy", "(1837-1901)", "MLA for Brant South", "21 July 1896", "21 October 1899", "Liberal Party"));
            premiers.Add(new Premier("Sir George William Ross", "(1841-1914)", "MLA for Middlesex West", "21 October 1899", "8 February 1905", "Liberal Party"));
            premiers.Add(new Premier("Sir James Whitney", "(1843-1914)", "MLA for Dundas", "8 February 1905", "25 September 1914", "Conservative Party"));
            premiers.Add(new Premier("Sir William Hearst", "(1864-1941)", "MLA for Sault Ste. Marie", "2 October 1914", "14 November 1919", "Conservative Party"));
            premiers.Add(new Premier("Ernest Drury", "(1878-1968)", "MLA for Halton", "14 November 1919", "16 July 1923", "United Farmers"));
            premiers.Add(new Premier("George Howard Ferguson", "(1870-1946)", "MLA for Grenville", "16 July 1923", "15 December 1930", "Conservative Party Named leader in 1920"));
            premiers.Add(new Premier("George Stewart Henry", "(1871-1958)", "MLA for York East", "15 December 1930", "10 July 1934", "Conservative Party"));
            premiers.Add(new Premier("Mitchell Hepburn", "(1896-1953)", "MLA for Elgin (until 1938) MPP for Elgin (from 1938)", "10 July 1934", "21 October 1942", "Liberal Party Named leader in 1930"));
            premiers.Add(new Premier("Gordon Daniel Conant", "(1885-1953)", "MPP for Ontario", "21 October 1942", "18 May 1943", "Liberal Party"));
            premiers.Add(new Premier("Harry Nixon", "(1891-1961)", "MPP for Brant", "18 May 1943", "17 August 1943", "Liberal Party Named leader in 1943"));
            premiers.Add(new Premier("George A. Drew", "(1894-1973)", "MPP for High Park (until 1948)", "17 August 1943", "19 October 1948", "Progressive Conservative Party Named leader in 1938"));
            premiers.Add(new Premier("Thomas Laird Kennedy", "(1878-1959)", "MPP for Peel", "19 October 1948", "4 May 1949", "Progressive Conservative Party"));
            premiers.Add(new Premier("Leslie Frost", "(1895-1973)", "MPP for Victoria", "4 May 1949", "8 November 1961", "Progressive Conservative Party Named leader in 1949"));
            premiers.Add(new Premier("John Robarts", "(1917-1982)", "MPP for London North", "8 November 1961", "1 March 1971", "Progressive Conservative Party Named leader in 1961"));
            premiers.Add(new Premier("Bill Davis", "(b. 1929)", "MPP for Peel North (until 1975) MPP for Brampton (from 1975)", "1 March 1971", "8 February 1985", "Progressive Conservative Party Named leader in 1971"));
            premiers.Add(new Premier("Frank Miller", "(1927-2000)", "MPP for Muskoka", "8 February 1985", "26 June 1985", "Progressive Conservative Partyamed leader in 1985"));
            premiers.Add(new Premier("David Peterson", "(b. 1943)", "MPP for London Centre", "26 June 1985", "1 October 1990", "Liberal Party Named leader in 1982"));
            premiers.Add(new Premier("Bob Rae", "(b. 1948)", "MPP for York South", "1 October 1990", "26 June 1995", "New Democratic Party Named leader in 1982"));
            premiers.Add(new Premier("Mike Harris", "(b. 1945)", "MPP for Nipissing", "26 June 1995", "14 April 2002", "Progressive Conservative Party Named leader in 1990"));
            premiers.Add(new Premier("Ernie Eves", "(b. 1946)", "MPP for Dufferin—Peel—Wellington—Grey", "15 April 2002", "22 October 2003", "Progressive Conservative Party Named leader in 2002"));
            premiers.Add(new Premier("Dalton McGuinty", "(b. 1955)", "MPP for Ottawa South", "23 October 2003", "11 February 2013", "Liberal Party Named leader in 1996"));
            premiers.Add(new Premier("Kathleen Wynne", "(b. 1953)", "MPP for Don Valley West", "11 February 2013", "Present", "Liberal Party Named leader in 2013"));

            return premiers;
        }
    }
}
