https://drive.google.com/file/d/1yiYDvdSjWvhkJyKg_OpMXixkukErQEGe/view?usp=sharing

Okay, now let's continue the last two points in part E Under each diagram, one sentence explaining what changed.
When I make order1 = new order, I make a reference to objects. And o2 from order2 reference to the same object.
o2.isPaid = true changes isPaid for both o1 and o2 because they have the same reference to the same object. 
The second point, what would be different with structs? With structs, the difference will be in two things. 
When I make order2 = o1, I didn't copy the reference or reference to the same object.
It is just a new object with the copy because struct is value type, so I just take a copy.
So o2.isPaid = true doesn't affect o1.isPaid. If I say o1.isPaid = false and o2.isPaid = true, o1.isPaid will still false.