**Assessment Brief**
Design and implement a programme that analyses an English language text file and prints statistics of characters and words.
Introduction
In the course of the module, you will learn to ..
-	build C# console application using .NET Framework. 
-	construct code: use types, create variables, design methods and code constructs, and design class.
This assignment provides you with the opportunity to consolidate your skills,  design, and implement the above concepts in a working program.
This assignment is designed on the narrative of frequency of words and letters in English text. For example, we expect the letter ‘E’ and word ‘THE’ to be the most frequent in English text. For more, see Appendix.
Your task is to write a C# console application that demonstrates frequency of letters and words through application on a text file.
You are provided with:
-	A Console application (TextStats) that includes: 
o	‘Algorithm.cs’: This class requires your implementation. In implementing this class, you are encouraged to consider good practice for code design. Good consideration needs to be given to method design, sensible use of types and variables, and good code construct. You may decide to divide the implementation across several classes by adding additional classes to the ‘CP’ namespace.
o	‘testfile.txt’: This file contain text for the analysis. You are not to make changes to this file. 
o	‘Program.cs’: You are not to make changes to this file.
o	‘Output analysis of testfile.JPG’: This is the expected output of analysis on ‘testfile.cs’. Use this as reference.
o	‘ASCII Reference.txt’: C# compares using the ASCII values. This is to be used as reference.

**Tasks**
-	Download ‘TextStats’ solution and implement
-	Based on the assumptions (see below), your application will:
o	Provide frequency of letters in ‘testfile.txt’
o	Provide frequency of words in ‘testfile.txt’
-	Zip ‘TextStats’ top solution folder and submit to the submission point on BB
  
**Assumptions **
-	Numeric and special characters are treated like space
o	‘20th’ is treated as the word ‘th’
o	'I co-wrote' is treated as 3 words: 'I', 'co' and 'wrote'
-	Words are to be treated as the uppercase version
o	'AMBIENT', 'Ambient' and 'ambient' are treated as "AMBIENT"
-	Letters are to be treated as the uppercase version
o	'A' and 'a' are both 'A'
-	Special characters are ignored. Not interested in frequency of '-' and ‘@’


