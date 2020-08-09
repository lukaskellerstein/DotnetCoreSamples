
# Concurrency (multitasking)

Doing a lot of things at once. 
Ex. One secretary is responsible (doing) multiple things: Answering on mails, Receiving the phone calls, doing a report for management. Secretary can do a multiple things, but only ONE AT THE TIME. => I/O bound problem
Ex. Cooking a breakfest

> Solving problems: IO-bound, CPU-bound

> I/O Bound

Will your code be "waiting" for something, such as data from a database?
- If your answer is "yes", then your work is **I/O-bound**.

> CPU bound

Will your code be performing an expensive computation?
- If you answered "yes", then your work is **CPU-bound**.

## Cooperative concurrency (multitasking) = TAP - Task-based Asynchronous Pattern

- Using `async` and `await` keywords
- Returns `Task<T>`

- **Using only 1 thread** 
(if you will not call Task.Run(), in that case it will run a new Thread)

- Same as EventLoop in Python, JS

## Pre-emptive concurrency (multitasking) = THREADING

- Thread 
- ThreadPool

- Same as Threads in Python, Similar to Goroutines in Go


# Parallelism = MULTIPROCESSING

FINISH

