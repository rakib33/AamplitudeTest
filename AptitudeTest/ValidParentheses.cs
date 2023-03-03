//using system;
//using system.collections;

//namespace aptitudetest
//{
//    https://www.geeksforgeeks.org/check-for-balanced-parentheses-in-an-expression/
//        a - question
//    given a string s containing just the characters (, ), {, }, [ and ], determine if the input string is valid.

//an input string is valid if,

//open brackets must be closed by the same type of brackets.
//open brackets must be closed in the correct order.
//example 1

//input: s = "()"
//output: true
//basic
//example 2

//input: s = "()[]{}"
//output: true
//basic
//example 3

//input: s = "(]"
//output: false
//basic
//example 4

//input: s = "([)]"
//output: false
//basic
//example 5

//input: s = "{[]}"
//output: true
//basic
//constraints

//1 <= s.length <= 10^4
//s consists of parentheses only ()[]{}.

//    public class validparentheses
//    {
//        public bool validinitialsolution(string s)
//        {
//            stack left = new stack();
//            foreach (char c in s.tochararray())
//            {
//                if (c == ( || c == { || c == [)
//                {
//                    left.push(c); // get left
//                }
//                // compare to right:
//                else if (c == ) && left.count != 0 && (char)left.peek() == ()
//                {
//                    left.pop();
//                }
//                else if (c == } && left.count != 0 && (char)left.peek() == {)
//                {
//                    left.pop();
//                }
//                else if (c == ] && left.count != 0 && (char)left.peek() == [)
//                {
//                    left.pop();
//                }
//                else
//                {
//                    return false; // no match
//                }
//            }
//            return true;
//        }

//        public bool validgoodsolution(string s)
//        {
//            int n = -1;
//            while (s.length != n)
//            {
//                n = s.length;
//                s = s.replace("()", "");
//                s = s.replace("{}", "");
//                s = s.replace("[]", "");
//            }
//            if (s.length == 0) return true;
//            else return false;
//        }
//    }
//}
