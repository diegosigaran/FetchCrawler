namespace Common.Enums;

public enum CrawlTaskStatus
{
    // Task has been created but is not yet eligible for execution.
    Pending = 0,

    // Task is eligible to be picked up by a worker.
    Queued = 1,

    // Task has been claimed by a worker but fetching has not started.
    Claimed = 2,

    // Worker is actively executing the task.
    Running = 3,

    // Task finished successfully.
    Completed = 4,

    // Task failed but can be attempted again.
    RetryScheduled = 5,

    // Task permanently failed or exhausted its retry limit.
    Failed = 6,

    // Task is temporarily prevented from executing.
    Suspended = 7,

    // Task was deliberately cancelled.
    Cancelled = 8,

    // Task was skipped because it was unnecessary.
    Skipped = 9,

    // Task was rejected by a crawl policy or safety restriction.
    Denied = 10,

    // Task was interrupted and needs recovery.
    Interrupted = 11
}