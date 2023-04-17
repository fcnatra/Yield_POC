# Yield use and performance test (List to dictionary using foreach vs Linq.ToDictionary) - Proof of concept

## List to dictionary using foreach vs Linq.ToDictionary
---- If the list has duplicated IDs and you want to use only the first ID object, use .GroupBy(o => o.Id) before .ToDictionary()

Seventh element: septh

## Yield use - Proof of concept

Creating yield element 0
enero
Creating yield element 1
febrero
Creating yield element 2
marzo
Creating yield element 3
abril
Creating yield element 4
mayo
Creating yield element 5
junio
Creating yield element 6
julio
Creating yield element 7
agosto
Creating yield element 8
septiembre
Creating yield element 9
octubre
Creating yield element 10
noviembre
Creating yield element 11
diciembre

Creating yield element 0
Creating yield element 1
Creating yield element 2
marzo
Creating yield element 3
Creating yield element 4
mayo
Creating yield element 5
Creating yield element 6
Creating yield element 7
Creating yield element 8
Creating yield element 9
Creating yield element 10
Creating yield element 11

END
