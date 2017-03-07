# C-_Practice_Delegates
Delegates are type safe function pointers
Delegate is a method  used to point to a function with similar signature. Its syntax is as follows for the function:
public void HelloFunc(string m1){} ->
public delegate void HelloDelegate(string msg);

To point to a function we need to create an instance of a delegate, which makes it similar to a class.
main()
{
HelloDelegate d1 = new HelloDelegate(HelloFunc);
d1("hai");
}

Why delegates are type safe?
Signature of delegate should match the signature of the function.If it does not match then compiler will alert you throwing an error,
so delegates are type safe function pointers.
