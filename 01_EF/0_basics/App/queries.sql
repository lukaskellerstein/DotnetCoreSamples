-- DROP DATABASE EFTest;

-- CREATE DATABASE EFTest;

/*
DELETE FROM [dbo].[LatencyMetrics];
DELETE FROM [dbo].[Builds];
DELETE FROM [dbo].[TestRuns];
DELETE FROM [dbo].[PullRequests];
*/


-- INSERT INTO [dbo].[Blogs] (Id, Url) VALUES (1,'http://www.receipts-awesomeness.pizza');
-- INSERT INTO [dbo].[Blogs] (Id, Url) VALUES (2,'http://www.delicious-dumpling.cz');
-- INSERT INTO [dbo].[Blogs] (Id, Url) VALUES (3, 'http://www.honest-guide.cz');

-- INSERT INTO [dbo].[Posts] (Id, Title, Content, BlogId) VALUES (1, 'Title1', 'flkajasldjfklajsklfjasjkfljasjflkasd', 1);
-- INSERT INTO [dbo].[Posts] (Id, Title, Content, BlogId) VALUES (2, 'Title2', 'erererer', 2);
-- INSERT INTO [dbo].[Posts] (Id, Title, Content, BlogId) VALUES (3, 'Pickpocketing in Wenceslaw Square', 'flkajasldjfklajsklfjasjkfljasjflkasd', 3);
-- INSERT INTO [dbo].[Posts] (Id, Title, Content, BlogId) VALUES (4, 'Pickpocketing in Muzeum', 'nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn', 3);
-- INSERT INTO [dbo].[Posts] (Id, Title, Content, BlogId) VALUES (5, 'Pickpocketing in Nusle', 'ddddddfsfdsdfddddddddddddrwerwerwerwer', 3);






-- SELECT *
--   FROM [EFTest].[dbo].[LatencyMetrics]


-- SELECT *
--   FROM [EFTest].[dbo].[PullRequests]

-- SELECT *
--   FROM [EFTest].[dbo].[TestRuns]


-- select * from TestRuns
-- select * from Builds

SELECT pr.*,  tr.*, lm.* from PullRequests as pr
left join TestRuns as tr on tr.PullRequestId = pr.Id
left join LatencyMetrics as lm on lm.TestRunId = tr.Id


SELECT pr.*, b.*, tr.*, lm.* from PullRequests as pr
left join Builds as b on b.PullRequestId = pr.Id
left join TestRuns as tr on tr.Id = b.Id
left join LatencyMetrics as lm on lm.TestRunId = tr.Id




SELECT pr.*, b.*, tr.*, lm.* from PullRequests as pr
left join Builds as b on b.PullRequestId = pr.Id and b.Origin = pr.Origin
left join TestRuns as tr on tr.BuildId = b.Id and tr.Origin = b.Origin
left join LatencyMetrics as lm on lm.TestRunId = tr.Id and lm.Origin = tr.Origin and lm.Content = tr.Content


-- -- DELETE FROM PullRequests_new

-- SELECT * from PullRequests_new


-- -- Select pr.Id, pr.Title Into PullRequests_new From PullRequests as pr

-- Insert into PullRequests_new (PullRequestId, Title) Select pr.Id, pr.Title from PullRequests as pr



