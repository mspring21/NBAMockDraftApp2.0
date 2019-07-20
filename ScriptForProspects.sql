USE MockDraftApp;
GO


BEGIN TRANSACTION;


Drop Table Teams
Drop Table Prospects



CREATE TABLE Prospects
(
	
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
	Steals decimal(3,1) not null



	
);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Zion Williamson', 19, 'Duke', 9, 'PF', '6''7"', 285, 22.6, 2.1, 8.9, 1.8, 2.1);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Ja Morant', 19, 'Murray State', 8, 'PG', '6''3"', 170, 24.5, 10.0, 5.7, 0.8, 1.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('R.J. Barrett', 19, 'Duke', 8, 'SF', '6''7"', 202, 22.6, 4.3, 7.6, 0.4, 0.9);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('De''Andre Hunter', 21, 'Virginia', 8, 'SF', '6''7"', 223, 15.2, 2.0, 5.1, 0.6, 0.6);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Darius Garland', 19, 'Vanderbilt', 10, 'PG', '6''3"', 173, 16.2, 2.6, 3.8, 0.4, 0.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Jarrett Culver', 19, 'Texas Tech', 8, 'SG', '6''6"', 194, 18.5, 3.7, 6.4, 0.6, 1.5);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Coby White', 19, 'North Carolina', 7, 'PG', '6''4"', 191, 16.1, 4.1, 3.5, 0.3, 1.1);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Jaxson Hayes', 19, 'Texas', 7, 'C', '6''11"', 219, 10.0, 0.3, 5.0, 2.2, 0.6);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Rui Hachimura', 21, 'Gonzaga', 8, 'PF', '6''8"', 225, 19.7, 1.5, 6.5, 0.7, 0.9);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Cam Reddish', 19, 'Duke', 6, 'SF', '6''8"', 208, 13.5, 1.9, 3.7, 0.6, 1.6);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Cameron Johnson', 23, 'North Carolina', 5, 'SF', '6''8"', 205, 16.9, 2.4, 5.8, 0.3, 1.2);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('P.J. Washington', 20, 'Kentucky', 6, 'PF', '6''8"', 230, 15.2, 1.8, 7.5, 1.2, 0.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Tyler Herro', 19, 'Kentucky', 6, 'SG', '6''6"', 192, 14.0, 4.5, 2.5, 0.3, 1.1);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Romeo Langford', 19, 'Indiana', 6, 'SG', '6''6"', 202, 16.5, 2.3, 5.4, 0.8, 0.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Sekou Doumbouya', 18, 'Limoges CSP', 5, 'PF', '6''9"', 230, 7.8, 0.7, 3.3, 0.5, 0.7);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Chuma Okeke', 20, 'Auburn', 5, 'PF', '6''8"', 235, 12.0, 1.9, 6.8, 1.2, 1.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Nickeil Alexander-Walker', 20, 'Virginia Tech', 6, 'SG', '6''5"', 204, 16.2, 4.0, 4.1, 0.5, 1.9);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Goga Bitadze', 19, 'Buducnost', 5, 'C', '6''11"', 250, 12.1, 1.2, 6.4, 2.3, 0.5);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Luka Samanic', 19, 'Petrol Olimpija', 8, 'PF', '6''11"', 227, 0, 0, 0, 0, 0);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Matisse Thybulle', 22, 'Washington', 5, 'SF', '6''5"', 190, 9.1, 2.1, 3.1, 2.3, 3.5);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Brandon Clarke', 22, 'Gonzaga', 9, 'PF', '6''8"', 207, 16.9, 1.9, 8.6, 3.2, 1.2);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Grant Williams', 20, 'Tennessee', 6, 'PF', '6''7"', 240, 18.8, 3.2, 7.5, 1.5, 1.1);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Darius Bazley', 19, 'N/A', 6, 'PF', '6''9"', 209, 0, 0, 0, 0, 0);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Ty Jerome', 21, 'Virginia', 8, 'PG', '6''5"', 194, 13.6, 5.5, 4.2, 0.0, 1.5);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Nassir Little', 19, 'North Carolina', 6, 'SF', '6''6"', 224, 9.8, 0.7, 4.6, 0.5, 0.5);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Dylan Windler', 22, 'Belmont', 7, 'SF', '6''7"', 196, 21.3, 2.5, 10.8, 0.6, 1.4);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Mfiondu Kabengele', 21, 'Florida State', 4, 'C', '6''10"', 256, 13.2, 0.3, 5.9, 1.5, 0.6);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Jordan Poole', 20, 'Michigan', 4, 'SG', '6''5"', 191, 12.8, 2.2, 3.0, 0.2, 1.1);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Keldon Johnson', 19, 'Kentucky', 4, 'SF', '6''6"', 216, 13.5, 1.6, 5.9, 0.2, 0.8);

Insert Prospects (ProspectName, Age, School, Rating, Position, Height, [Weight], Points, Assists, Rebounds, Blocks, Steals)
Values ('Kevin Porter Jr.', 19, 'USC', 6, 'SG', '6''5"', 213, 9.5, 1.4, 4.0, 0.5, 0.8);



CREATE TABLE Teams
(

	TeamName varchar(50) not null,
	TeamNeeds varchar(50) not null,
	TeamPicture varchar(50) not null,

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