N integers A1,A2,…,AN are placed in a circle in such a way that for each valid i, Ai and Ai+1 are adjacent, and A1 and AN are also adjacent.

We want to repeat the following operation exactly N−1 times (until only one number remains):

Select two adjacent numbers. Let's denote them by a and b.
Score a+b penalty points.
Erase both a and b from the circle and insert a+b in the space between them.
What is the minimum number of penalty points we can score?

Input
The first line of the input contains a single integer T denoting the number of test cases. The description of T test cases follows.
The first line of each test case contains a single integer N.
The second line contains N space-separated integers a1,a2,…,aN.
Output
For each test case, print a single line containing one integer — the minimum number of penalty points.

Constraints
1≤T≤10
2≤N≤400
1≤ai≤109 for each valid i
Subtasks
Subtask #1 (10 points):

2≤N≤10
ai≤10 for each valid i
Subtask #2 (10 points):

2≤N≤25
a1,a2,…,aN are distinct powers of 2 (including 1)
Subtask #3 (10 points): 2≤N≤100
Subtask #4 (70 points): original constraints

Example Input
1
3
10 10 1
Example Output
32
Explanation
[10,10,1]→[10,11], penalty: 11
[10,11]→[21], penalty: 21
Total penalty: 11+21=32

Solutions:

import sys
for _ in range(int(input())):
    n=int(input())
    A=list(map(int,input().split()))
    penalty=0
    while len(A)>1:
        sum=sys.maxsize
        for i in range(len(A)):
            if A[i]+A[(i+1)%len(A)]<sum:
                sum=A[i]+A[(i+1)%len(A)]
                j=i
        A.insert(j,sum)
        penalty+=sum
        A.remove(A[j+1])
        A.remove(A[(j+1)%len(A)])
        
    print(penalty)