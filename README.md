# Yield use and performance test (List to dictionary using foreach vs Linq.ToDictionary) - Proof of concept

## List to dictionary using foreach vs Linq.ToDictionary
---- If the list has duplicated IDs and you want to use only the first ID object, use .GroupBy(o => o.Id) before .ToDictionary()

Result of the execution shows:

Seventh element: septh

## Yield use - Proof of concept

Result of the execution shows:

Creating yield element 0
<br/>enero
<br/>Creating yield element 1
<br/>febrero
<br/>Creating yield element 2
<br/>marzo
<br/>Creating yield element 3
<br/>abril
<br/>Creating yield element 4
<br/>mayo
<br/>Creating yield element 5
<br/>junio
<br/>Creating yield element 6
<br/>julio
<br/>Creating yield element 7
<br/>agosto
<br/>Creating yield element 8
<br/>septiembre
<br/>Creating yield element 9
<br/>octubre
<br/>Creating yield element 10
<br/>noviembre
<br/>Creating yield element 11
<br/>diciembre
<br/>
<br/>Creating yield element 0
<br/>Creating yield element 1
<br/>Creating yield element 2
<br/>marzo
<br/>Creating yield element 3
<br/>Creating yield element 4
<br/>mayo
<br/>Creating yield element 5
<br/>Creating yield element 6
<br/>Creating yield element 7
<br/>Creating yield element 8
<br/>Creating yield element 9
<br/>Creating yield element 10
<br/>Creating yield element 11

END
