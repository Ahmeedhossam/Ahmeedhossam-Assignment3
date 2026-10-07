// انا قولت الشرح كله في ريكورد عشان طويل وخليت شات جيبيتي ينسقه فقط لا غير
/*# 1. File-Scoped Namespace

Regarding the **file-scoped namespace**, the difference between it and the regular namespace with **curly brackets** is that I use a **semicolon** instead of those curly brackets.

So, what does this help me with?

It means that I don't need to have that extra **level of indentation**.

For example, I don't need to have the two curly brackets for the namespace and then have an indentation for the class inside it, where it would be shifted a little to the right, maybe around five spaces or something like that, and then the class would also have its own curly brackets, and I would add things inside it, and so on.

No. I replace all of that with a **semicolon**, and everything stays at the same level of indentation. I know that anything below the namespace after I use the semicolon belongs to that namespace; it is inside it.

So, this is the **file-scoped namespace** part.

Therefore, as we agreed, there is no longer a **level of indentation**. Everything inside something does not have to be shifted by a certain number of spaces for us to consider it inside that thing. No, everything stays at the same level, and I know that everything below it is inside the namespace.

That's it regarding the **file-scoped namespace**.

---

# 2. Program.cs

Now, we can talk about the second required thing, which is **Program.cs**.

**Program.cs** is like the **entry point** of my project. It is the thing from which I start my project.

I can create the file and make it use **top-level statements**.

I don't have the part where I explicitly have a **Class** and a **Main** method and so on, but they are created **under the hood**.

However, I still need to understand that I have an **Entry point** and a **Main method**, which is the method that gets executed at the entry point when I run the project.

And **Program.cs** is treated as a kind of **Configuration** for my project.

I connect the **Database**, connect my things, or set up my work. The things that I use to connect everything together are all in **Program.cs**.

Whether I use the **Top-level statement** that we used or not, under the hood, we still have the **Class**, the **Main method**, and the things related to the **Entry point**.

Okay?

The **Best practice** for this file is that we don't use **Business logic**.

It only connects things together and performs the tasks related to **connecting and running** the application.

But if I want to create certain functionalities or certain **Methods**, then we go back to my **Classes**.

I have a **Class**, and each Class does its own thing. Then I connect these things together and use them in the **Main**.

---

# 3. `.csproj`

Let's talk about the **`.csproj`**.

The `.csproj` is what shows me and explains to the **compiler** all the details of my project.

For example, whether it is an **EXE** or not.

If we are talking about a **Library**, for example, it will be a **DLL** file that can be referenced.

It also shows me the **.NET framework**, such as **.NET 10**, **.NET 9**, and so on, because I am committed to a specific version.

I cannot, for example, use something from **.NET 10** while my **Target Framework** is **.NET 9**.

---

# 4. Implicit Usings

I also have **Implicit Usings**.

For example, it creates a hidden file that contains all the common `using` statements.

For example, instead of me writing a `using` statement, it automatically adds things such as `using System.Linq`, `using` something else, and so on.

So, this helps me because it creates a file that contains all the `using` statements that I might need.

This is **Implicit Usings**.

---

# 5. Nullable

Then we have **Nullable**.

When I set it to **enable**, it checks with me if there is a **null** in the project and gives me something like a **warning**.

It keeps track of it instead of waiting for an **exception** to happen and for the project to crash.

It handles this part by checking with me if there is something that can be `null`.

It performs **analysis at compile time** to track the reference.

If there is a `null` in the reference, it makes sure that I have checked for `null` before using it.

So, this is a feature that prevents me from getting a **NullReferenceException** or having something fail at **runtime**.

---

# 6. Main Things in the `.csproj`

So, these are the main things that I need to know so far, and they are considered the most important things in the **`.csproj`** file.

It is basically the **brain of the project**.

My compiler cannot understand the project without the `.csproj` file.

And there is also something that I forgot to add: it is an **XML file**.

It is an XML file so that I can understand how the code is built, the packages that I have, what the result is like, what its type is, and so on.

That's it.

---

# 7. EXE

And another thing I want to add is that the **EXE** file, for example, when I have something like a **Web API** or a **Console Application**, can produce an **EXE** file.

So, that's what we talked about regarding the **`.csproj`**.

---

# 8. Which Format Do I Use: `.sln` or `.slnx`?

Regarding **which format I use in `.sln` and `.slnx`**, I use **`.slnx`**.

And one advantage of the one I didn't choose:

Let's agree that **`.sln`** currently can be considered useful, but instead of saying that it has an advantage, we can say that it is **very suitable for old projects**.

I will be able to work with old projects when I understand it.

It will be better for old projects.

It is an old format, but I will find it used in old projects, so understanding it is the thing that will help me.

However, I think using **`.sln`** is not preferred now. **`.slnx`** is better.

**`.sln`** is used with older frameworks, old projects, and so on.

So, the main point here is the **compatibility with older versions**.

# 9. `obj` and `bin`

## `obj`

Regarding **`obj`**, I use it during the **build**.

It contains some things that are used during the build process.

It takes my code and processes it before producing its final form.

We also agreed that we **do not upload the `obj` folder to Git**. This is also an important point.

It is like a **draft**.

The compiler puts temporary things inside it during the build so that it can connect the code together.

Nobody really sees it except the **compiler**.

And if I delete it, every time I perform a **build**, it gets created again.

---

## `bin`

The **`bin`** is the final thing for the project.

After the compiler finishes its work in `obj`, the final result is placed inside `bin`.

This is the thing that gets released — the **final version**.

I find my **DLL** files and the **EXE** file there.

So, this is the final folder after I finish my work in `obj`.

This is the folder that we take and upload to the **server**: the `bin` folder.

*/

using CSharpBasicsAssignment;

Console.WriteLine("Project & Structure in comments uppper");
Console.WriteLine("===============");
Console.WriteLine("Part B — Variables, Types & Casting  ");
RunTypesDemo();
RunValueVsReferenceDemo();

void RunTypesDemo()
{
    int x = 10;
    float y = 15.5f;
    decimal o = 1212.4212m;
    double k = 34.51;
    long m = 2312311;
    bool b = false;
    var n = 'c';
    char t = 'q';
    long h = x;
    int p = t;
    int z = (int)k;
    Console.WriteLine(x.GetType());
    Console.WriteLine(n.GetType());
    Console.WriteLine(y.GetType());
    Console.WriteLine(o.GetType());
    Console.WriteLine(k.GetType());
    Console.WriteLine(m.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(t.GetType());
    Console.WriteLine(n);
    Console.WriteLine(y);
    Console.WriteLine(o);
    Console.WriteLine(k);
    Console.WriteLine(m);
    Console.WriteLine(b);
    Console.WriteLine(t);
    Console.WriteLine($"{h},,{p}");
    // no casting required in h , p cuz they are bigger in bits so safe casting(implicit) is done under the hood
    Console.WriteLine($"z with casting double into int to it is {z} and with convert to int is {Convert.ToInt32(k)} ");
    // convert to int use rounding like << .5 goes to .0 and >>.5 goes to the next number but casting truncate all after the point like 3.7 or 3.2 will be 3
    int q = 5 / 2;
    Console.WriteLine(q);
    double a = 5.0 / 2;
    Console.WriteLine(a);
    // cuz a is double it will gimme 2.5 but the q gimme 2 cuz its int so it will truncate any decimal
    object j = q;
    Console.WriteLine(j);
    int u = (int)j;
    Console.WriteLine(u);
    string c = "42";
    string H = "abc";
    Console.WriteLine($"int.parse{int.Parse(c)},,,,,,,int.tryparse {int.TryParse(H, out int i)}");
    // try parse handle exception without throwing cuz it returns false in case of failture
    Console.WriteLine(c);
    decimal B = 3.44454m;
    //float A = B; will not work cuz B is bigger in bits than A so we need excplicit casting
    float A = (float)B;

    Console.ReadLine();
}
void RunValueVsReferenceDemo()
{
    point p1 = new point() { X = 1, Y = 2 };
    point p2 = p1;
    p2.X = 99;
    Console.WriteLine($"p1.x {p1.X}   p2.x {p2.X}");
    // p1.x does not change to 99 cuz X is Value type so p2.X is just a copy so when i make P2.X = 99 I JUST CHANGED the copy so p1 does not effected
    Order o1 = new Order
    {
        OrderId = 101,
        CustomerName = "Ahmed",
        Quantity = 2,
        UnitPrice = 50m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 10,
        ShippingCity = "Cairo",
        Priority = 'H',
        ItemCode = 1001L
    };
    o1.CalculateTotal();
    Order o2 = o1;
    o2.IsPaid = true;
    Console.WriteLine($"o1 ispaid {o1.IsPaid}  and o2 ispaid {o2.IsPaid} ");
    // now they are the same cuz o1 and o2 refrence to the same object in heap

    object boxedOrder = o1;
    Order o3 = (Order)boxedOrder;
    Console.WriteLine(object.ReferenceEquals(o1, o3)); // it's the exact same instance

    o2.PrintSummary();
    Console.ReadLine();
}

internal struct point
{
    public int X;
    public int Y;
}