
/* ==================================================
Teams Table
===================================================== */
select * from Teams


/* ==================================================
Prospects Table
===================================================== */
select * from Prospects


/* ==================================================
Prospects Available for Draft
===================================================== */
select * from Prospects where DraftedStatus = 1


/* ==================================================
Drafted Prospects
===================================================== */
select * from Prospects where DraftedStatus = 2


/* ==================================================
Top 5 Available Prospects
===================================================== */
select top(5) * from Prospects where DraftedStatus = 1 order by Rating	desc 


/* ==================================================
Update Prospect after getting Drafted
===================================================== */
Update Prospects Set DraftedStatus = 2, TeamDrafted = 'New Orleans Pelicans' where Id = 1


/* ==================================================
Reset all players back to undrafted and blank teamDrafted
===================================================== */
Update Prospects Set DraftedStatus = 1, TeamDrafted = ''



/* ==================================================
Get single Prospect by Id
===================================================== */
select * from Prospects where Id = 1


/* ==================================================

===================================================== */



