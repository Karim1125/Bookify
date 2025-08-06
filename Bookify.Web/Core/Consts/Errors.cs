﻿namespace Bookify.Web.Core.Consts
{
    public static class Errors
    {
        public const string MaxLength = "The maximum length for this field is {1} characters.";
        public const string Duplicated = "{0} with the same name is already exists!";
        public const string DuplicatedBook = "Book with the same title is already exists with the same author!";
        public const string NotAllowedFileType = "Only .png, .jpg, .jpeg files are allowed";
        public const string MaxSize = "File cannot be more than 2 MB!";
        public const string NotAllowedFutureDates = "Date cannot be in the future!";
    }
}
