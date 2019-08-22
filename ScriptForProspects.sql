-- Switch to the system (aka master) database
USE master;
GO

-- Delete the DemoDB Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='MockDraftApp')
DROP DATABASE MockDraftApp;
GO

-- Create a new DemoDB Database
CREATE DATABASE MockDraftApp;
GO

USE MockDraftApp;
GO


BEGIN TRANSACTION;


Drop Table Teams
Drop Table Prospects



CREATE TABLE Prospects
(
	Id		int		identity(1,1),
	ProspectName	varchar(50)	not null,
	Age		int	not null,
	School varchar(50) not null,
	Rating int not null,
	Position varchar(50) not null,
	Height varchar(10) not null,
	[Weight] int not null,
	Points decimal(3,1) not null,
	Assists decimal(3,1) not null,
	Rebounds decimal(3,1) not null,
	Blocks decimal(3,1) not null,
	Steals decimal(3,1) not null,
	ProfilePhoto varchar(500) not null,
	DraftedStatus	int		not null,
	TeamDrafted		varchar(50)


	
);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Zion Williamson', 19, 'Duke', 9, 'PF', '6''7"', 285, 22.6, 2.1, 8.9, 1.8, 2.1, 'https://neulioncs.hs.llnwd.net/pics33/400/YO/YOLAZZASVAVVZAO.20180808222629.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Ja Morant', 19, 'Murray State', 9, 'PG', '6''3"', 170, 24.5, 10.0, 5.7, 0.8, 1.8, 'https://goracers.com/images/2018/7/24/07_24_18WEB1FINAL_MORANT_Ja.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('R.J. Barrett', 19, 'Duke', 8, 'SF', '6''7"', 202, 22.6, 4.3, 7.6, 0.4, 0.9, 'https://neulioncs.hs.llnwd.net/pics33/400/UI/UIMLWFLJRFAPUYI.20180808221301.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('De''Andre Hunter', 21, 'Virginia', 8, 'SF', '6''7"', 223, 15.2, 2.0, 5.1, 0.6, 0.6, 'https://virginiasports.com/images/2018/7/12/12_Hunter_De_Andre.JPG', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Darius Garland', 19, 'Vanderbilt', 10, 'PG', '6''3"', 173, 16.2, 2.6, 3.8, 0.4, 0.8, 'https://d2zj7tzv8omdiw.cloudfront.net/brentwoodhp/wp-content/uploads/2019/07/Garland.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Jarrett Culver', 19, 'Texas Tech', 8, 'SG', '6''6"', 194, 18.5, 3.7, 6.4, 0.6, 1.5, 'https://cdn.nba.net/nba-drupal-prod/styles/landscape/s3/2019-05/jarrett-culver-iso-texas-tech.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Coby White', 19, 'North Carolina', 7, 'PG', '6''4"', 191, 16.1, 4.1, 3.5, 0.3, 1.1, 'https://sportshub.cbsistatic.com/i/r/2019/03/06/c18945a4-9dfd-400f-bb48-7b8baa8326be/thumbnail/1200x675/e33c5f803e5a20b3a218fa49eb06c4e8/usatsi-12183430.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Jaxson Hayes', 19, 'Texas', 7, 'C', '6''11"', 219, 10.0, 0.3, 5.0, 2.2, 0.6, 'https://media.video-cdn.espn.com/motion/2019/0619/dm_190619_theundefeated_jaxson_hayes_journey_to_nba/dm_190619_theundefeated_jaxson_hayes_journey_to_nba.jpg?w=640', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Rui Hachimura', 21, 'Gonzaga', 8, 'PF', '6''8"', 225, 19.7, 1.5, 6.5, 0.7, 0.9, 'https://cdn.japantimes.2xx.jp/wp-content/uploads/2018/03/sp-kaz-a-20180322-870x580.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Cam Reddish', 19, 'Duke', 6, 'SF', '6''8"', 208, 13.5, 1.9, 3.7, 0.6, 1.6, 'https://mk0slamonlinensgt39k.kinstacdn.com/wp-content/uploads/2019/03/cam2.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Cameron Johnson', 23, 'North Carolina', 5, 'SF', '6''8"', 205, 16.9, 2.4, 5.8, 0.3, 1.2, 'https://dbukjj6eu5tsf.cloudfront.net/sidearm.sites/unc.sidearmsports.com/images/2019/3/2/Johnson_UNC_Clemson_2019_DP_5271.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('P.J. Washington', 20, 'Kentucky', 6, 'PF', '6''8"', 230, 15.2, 1.8, 7.5, 1.2, 0.8, 'https://cdn-s3.si.com/s3fs-public/styles/marquee_large_2x/public/2019/03/20/pj-washington-foot-sprain-ncaa-tournament.jpg?itok=O1bGgFQJ', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Tyler Herro', 19, 'Kentucky', 6, 'SG', '6''6"', 192, 14.0, 4.5, 2.5, 0.3, 1.1, 'https://img.bleacherreport.net/img/article/media_slots/photos/002/888/422/03a88b7e49335e319b04728ac8eeb9fa_crop_exact.jpg?w=2975&h=2048&q=85', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Romeo Langford', 19, 'Indiana', 6, 'SG', '6''6"', 202, 16.5, 2.3, 5.4, 0.8, 0.8, 'https://imagesvc.timeincapp.com/v3/fan/image?url=https://inkonindy.com/wp-content/uploads/getty-images/2017/07/1082848588-1.jpeg&c=sc&w=850&h=560', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Sekou Doumbouya', 18, 'Limoges CSP', 5, 'PF', '6''9"', 230, 7.8, 0.7, 3.3, 0.5, 0.7, 'https://sportshub.cbsistatic.com/i/r/2019/02/15/1529f61a-0d04-470b-9065-ce0eaaf90d90/thumbnail/770x433/5336a6e9fbb210d3b89ca4c74814131c/sekou-doumbouya.png', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Chuma Okeke', 20, 'Auburn', 5, 'PF', '6''8"', 235, 12.0, 1.9, 6.8, 1.2, 1.8, 'https://imagesvc.timeincapp.com/v3/fan/image?url=https://orlandomagicdaily.com/wp-content/uploads/getty-images/2017/07/1139366722.jpeg&', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Nickeil Alexander-Walker', 20, 'Virginia Tech', 6, 'SG', '6''5"', 204, 16.2, 4.0, 4.1, 0.5, 1.9, 'https://www.nba.com/timberwolves/sites/timberwolves/files/naw.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Goga Bitadze', 19, 'Buducnost', 5, 'C', '6''11"', 250, 12.1, 1.2, 6.4, 2.3, 0.5, 'https://agenda.ge/files/articles/goga-bitadze.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Luka Samanic', 19, 'Petrol Olimpija', 8, 'PF', '6''11"', 227, 0, 0, 0, 0, 0, 'https://imagesvc.timeincapp.com/v3/fan/image?url=https://thunderousintentions.com/wp-content/uploads/getty-images/2017/07/1143782141.jpeg&c=sc&w=3200&h=2133', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Matisse Thybulle', 22, 'Washington', 5, 'SF', '6''5"', 190, 9.1, 2.1, 3.1, 2.3, 3.5, 'https://imagesvc.timeincapp.com/v3/mm/image?url=https://cdn-s3.si.com/images/washington-Matisse-Thybulle-inline-2.jpg&w=1600&h=1200&c=sc&poi=face&q=85', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Brandon Clarke', 22, 'Gonzaga', 9, 'PF', '6''8"', 207, 16.9, 1.9, 8.6, 3.2, 1.2, 'https://www.nba.com/hawks/sites/hawks/files/styles/story_main_photo/public/brandon_clarke_profile.jpg?itok=w8I76s-d', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Grant Williams', 20, 'Tennessee', 6, 'PF', '6''7"', 240, 18.8, 3.2, 7.5, 1.5, 1.1, 'https://utsports.com/images/2019/1/27/216117_20181004_MB_MediaDay_AF_017.jpg?width=1061&height=597&mode=crop', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Darius Bazley', 19, 'N/A', 6, 'PF', '6''9"', 209, 0, 0, 0, 0, 0, 'https://clutchpoints.com/wp-content/uploads/2019/07/T27-1.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Ty Jerome', 21, 'Virginia', 8, 'PG', '6''5"', 194, 13.6, 5.5, 4.2, 0.0, 1.5, 'https://www.washingtonpost.com/resizer/BnYUleXynBJFNOAIJ7hwVxiIUiQ=/1484x0/arc-anglerfish-washpost-prod-washpost.s3.amazonaws.com/public/Y6FZ3WS2OEI6TGGUQRAIRUJV6I.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Nassir Little', 19, 'North Carolina', 6, 'SF', '6''6"', 224, 9.8, 0.7, 4.6, 0.5, 0.5, 'https://2.bp.blogspot.com/-8ikbkQIDt1A/XNyuII3sKMI/AAAAAAAAGjc/S4aDTCNylA81S1GMMjeECo8yr6j7W38PgCLcBGAs/s1600/little.png', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Dylan Windler', 22, 'Belmont', 7, 'SF', '6''7"', 196, 21.3, 2.5, 10.8, 0.6, 1.4, 'https://closeup360.com/wp-content/uploads/2019/05/Header-3.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Mfiondu Kabengele', 21, 'Florida State', 4, 'C', '6''10"', 256, 13.2, 0.3, 5.9, 1.5, 0.6, 'https://i1.wp.com/basketballsocietyonline.com/wp-content/uploads/2019/04/mfioundu-kabengele.jpg?fit=1024%2C683&ssl=1', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Jordan Poole', 20, 'Michigan', 4, 'SG', '6''5"', 191, 12.8, 2.2, 3.0, 0.2, 1.1, 'https://cdn.theathletic.com/app/uploads/2018/01/29231824/GettyImages-9054235781-1024x580.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Keldon Johnson', 19, 'Kentucky', 4, 'SF', '6''6"', 216, 13.5, 1.6, 5.9, 0.2, 0.8, 'https://s.hdnux.com/photos/01/01/20/47/17107392/3/rawImage.jpg', 1, '');

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals, ProfilePhoto, DraftedStatus, TeamDrafted)
Values ('Kevin Porter Jr.', 19, 'USC', 6, 'SG', '6''5"', 213, 9.5, 1.4, 4.0, 0.5, 0.8, 'https://imagesvc.timeincapp.com/v3/fan/image?url=https://wizofawes.com/wp-content/uploads/getty-images/2017/07/1128161542.jpeg&', 1, '');



CREATE TABLE Teams
(
	Id		int		identity(1,1),
	TeamName varchar(50) not null,
	TeamNeeds varchar(50) not null,
	TeamPicture varchar(50) not null

);

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('New Orleans Pelicans', 'PG, shooting, SF', 'pelicansLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Memphis Grizzles', 'PG, SG, stretch-4', 'grizzliesLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('New York Knicks', 'Everything besides a starting C', 'knicksLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Los Angeles Lakers', 'PG, shooting, wing defense', 'lakersLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Cleveland Cavaliers', 'Combo guard, 3-and-D wing', 'cavsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Phenoix Suns', 'PG, NBA-caliber bench', 'sunsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Chichago Bulls', 'PG', 'bullsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Atlanta Hawks', 'Rim-protecting C, depth', 'hawksLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Washington Wizards', 'Versatile forwards', 'wizardsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Dallas Mavericks', 'PG, shooters, C', 'mavsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Minnesota TimberWolves', 'PG, depth at SF/PF', 'timberwolvesLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Charlotte Hornets', 'PG', 'hornetsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Miami Heat', 'Improved role players', 'heatLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Sacromento Kings', 'Starting C, bench wings', 'kingsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Boston Celtics', 'G/F/C in case FAs leave', 'celticsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Detroit Pistons', 'Versatile wings, depth at SF/C', 'pistonsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Orlando Magic', 'Depth at wing spots', 'magicLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Brooklyn Nets', 'PG, stretch-4, backup C', 'netsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Indiana Pacers', 'PG, SF, secondary scorer', 'pacersLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('San Antonio Spurs', 'Big wings', 'spursLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Los Angeles Clippers', 'SF, depth at PF/C', 'clippersLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Oklahoma Thunder', 'Stretch-4, shooting', 'thunderLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Utah Jazz', 'Bench shooters', 'jazzLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Philadelphia 76ers', 'Bench depth', 'sixersLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Portland Trailblazers', 'Bench guards and C', 'blazersLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Houston Rockets', 'Backup PG, bench scoring', 'rocketsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Denver Nuggets', 'Stretch-4, big wing', 'nuggetsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Golden State Warriors', 'SG, SF, bench depth', 'warriorsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Toronto Raptors', 'SF, wing depth', 'raptorsLogo')

Insert Teams (TeamName, TeamNeeds, TeamPicture)
Values ('Milliwakue Bucks', 'Backup PG', 'bucksLogo')



COMMIT TRANSACTION;