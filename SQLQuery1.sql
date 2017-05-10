Select Top(10) Names.Name, ID.StationID, Sum(DailyTotal) as Total
From Riderships as ID
INNER JOIN Stations as Names 
ON ID.StationID = Names.StationID
Group by Names.Name, ID.StationID
Order by Total DESC