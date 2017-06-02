CREATE TABLE [dbo].[Table] (
    [Delhi_Address]   NVARCHAR (140) NOT NULL,
    [Delhi_Pincode]   INT            NOT NULL,
    [Delhi_Telephone] VARCHAR(11)            NULL,
    [Delhi_Mobile]    VARCHAR(11)            NOT NULL,
    [Per_Address]     NVARCHAR (140) NOT NULL,
    [Per_Pincode]     INT            NOT NULL,
    [Per_Telephone]   VARCHAR(11)            NULL,
    [Per_Mobile]      VARCHAR(11)            NULL,
    PRIMARY KEY CLUSTERED ([Delhi_Mobile] ASC)
);

