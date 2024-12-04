# Parking

Disclaimer:
There are MANY ways to solve this problem. My main thoughts are about having a flexbile solution and about aenemic domain model.
regarding aenemic domain model: I think in real prod code, you'll have the DTO to represent the database, in which those models would have their own data and won't mix (so parking spot would just represents the spot, not the vehicle on it). Now the rich domain model would have the relations, so a spot would have the vehicle on it.
I did not implement everything, I just need more time.
In general I follow OOP prinicples. in prod code I would add:
tests, a factory class to build up the lot/garage, add db with concurrency (think about few parking entrances and multiple cars trying to get in).
