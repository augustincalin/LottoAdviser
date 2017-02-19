# LottoAdviser
Educational project using ASP.NET Core 1.1, Visual Studio 2017 RC, Entity Framework Core 1.0, Angular 2 with TypeScript, Javascript services with Webpack, Bootstrap

##Pretext
Give a "most probable" numbers from German lottery to appear in the next draw.

A number is more probable to be extracted (or drawn) as it's missing for a longer time and it was lesser extracted. The importance of these factors is considered equal (naive approach, I know).

####Example
Let's suppose:

Number | Last seen (draws ago) *NotSeen* | Until now it was extracted *Occurencies*
------ | --------------------- | --------------------------
12 | 16 | 123
22 | 1 | 200
Then we can say 12 is more likely to be extracted in the next draw because: 1) it appearead 16 draws ago and 2) it was extracted fewer times than 22.

The formula used is very basic: probability = Factor1 x NotSeen x Factor2 x (1 / Occurencies)

Factor1 and Factor2 are some parameters for future pondering the weight of the two factors in the final result. Right now they are equal with 1 but configurable in database.

####Issues, problems, nice things
* configuration taken from database
* resolve some services using configuration
* lotto-hessen.de is not offering a RSS or API service to get the statistics. Therefore the page is taken and parsed using regular expressions
* lotto-hessen.de is giving separate statistics for "missing since" information splited by the day of draw: Wednesday or Saturday - therefore some additional processing is needed

####Future improvements
* adjust Factor1 and Factor2 after each draw
* async for loading the statistics, eventually with a nice progress bar
* don't allow the user to fetch data if this was already refreshed
* better visualization

