Console Application<br>
Exercises: Sets and Dictionaries Advanced
# Ranking
Write a program that __ranks__ candidate-interns, depending on the __points__ from the __interview tasks__ and their __exam results__ in SoftUni. You will receive some lines of __input__ in the format "__{contest}:{password for contest}__" until you receive "__end of contests__". Save that data because __you will need it later__. After that you will receive other type of inputs in format "__{contest}=>{password}=>{username}=>{points}__" until you receive "__end of submissions__". Here is what you need to do:
- Check if the contest is __valid__ (if you received it in the first type of input)
- Check if the __password is correct__ for the given contest
- Save the __user__ with the __contest__ they take part in (__a user can take part in many contests__) and the __points__ the user has in the given contest. If you receive the __same contest__ and the same user, __update__ the points __only__ if the new ones are __more__ than the older ones.
 
At the end you have to print the info for the user with __the most points__ in the format:

"__Best candidate is {user} with total {total points} points.__".

After that print __all students__ ordered by their __names__. For each user, print __each contest__ with the __points in descending order__ in the following format:

"__{user1 name}<br>
\#  {contest1} -> {points}<br>
\#  {contest2} -> {points}<br>
{user2 name}<br>
…__"

## Input
- You will be receiving strings in formats described above, until the appropriate commands, also described above, are given.
## Output
- On the __first__ line print the best user in the format described above. 
- On the __next lines__ print all students ordered as mentioned above in format.
## Constraints
- There will be __no case__ with two equal contests.
- The __strings__ may contain any ASCII character except from (__:, =, >__).
- The __numbers__ will be in range __[0 - 10000]__.
- The __second__ input is always __valid__.
- There will be __no case__ with __2 or more__ users with same total points.
## Examples
Input|Output
-----|------
Part One Interview:success<br>Js Fundamentals:Peter<br>C# Fundamentals:fundPass<br>Algorithms:fun<br>end of contests<br>C# Fundamentals=>fundPass=>Tanya=>350<br>Algorithms=>fun=>Tanya=>380<br>Part One Interview=>success=>Nikola=>120<br>Java Basics Exam=>pesho=>PeterPeter=>400<br>Part One Interview=>success=>Tanya=>220<br>OOP Advanced=>password123=>JohnJohn=>231<br>C# Fundamentals=>fundPass=>Tanya=>250<br>C# Fundamentals=>fundPass=>Nikola=>200<br>Js Fundamentals=>Peter=>Tanya=>400<br>end of submissions|Best candidate is Tanya with total 1350 points.<br>Ranking:<br>Nikola<br>#  C# Fundamentals -> 200<br>#  Part One Interview -> 120<br>Tanya<br>#  Js Fundamentals -> 400<br>#  Algorithms -> 380<br>#  C# Fundamentals -> 350<br>#  Part One Interview -> 220
Java Advanced:funpass<br>Part Two Interview:success<br>Math Concept:asdasd<br>Java Web Basics:forrF<br>end of contests<br>Math Concept=>ispass=>Monika=>290<br>Java Advanced=>funpass=>Simona=>400<br>Part Two Interview=>success=>Dany=>120<br>Java Advanced=>funpass=>Peter=>90<br>Java Web Basics=>forrF=>Simona=>280<br>Part Two Interview=>success=>Peter=>0<br>Math Concept=>asdasd=>Dany=>250<br>Part Two Interview=>success=>Simona=>200<br>end of submissions|Best candidate is Simona with total 880 points.<br>Ranking:<br>Dany<br>#  Math Concept -> 250<br>#  Part Two Interview -> 120<br>Peter<br>#  Java Advanced -> 90<br>#  Part Two Interview -> 0<br>Simona<br>#  Java Advanced -> 400<br>#  Java Web Basics -> 280<br>#  Part Two Interview -> 200
