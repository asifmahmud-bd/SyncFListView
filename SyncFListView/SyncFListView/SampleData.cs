using System;
using System.Collections.Generic;
using System.Text;

namespace SyncFListView
{
    class SampleData
    {

        //public async Task<Document> InsertArticaleWithAttachment()
        //{
        //    var repsotary = new CouchbaseRepository(new DbContext());
        //    string attachmentPath = FileSystem.Current.LocalStorage.Path;
        //    var imagesList = await FilesFromLocalStroage();
        //    Random rnd = new Random();

        //    int numberOfFiles = 0;
        //    int groupId = 1000;
        //    int subGroupId = 100;

        //    //Insert articale 
        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();

        //    if (null != imagesList)
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            groupId++;

        //            foreach (var file in imagesList)
        //            {
        //                var attachments = new Document("IFSID_" + numberOfFiles);

        //                attachments.Set("article_id", "IFSID_" + numberOfFiles);
        //                attachments.Set("catalog_name", "MIELE Domestic");
        //                attachments.Set("type", "product");
        //                attachments.Set("supplier_pid", "articlenr");
        //                attachments.Set("catalog_id", "BMECAT_NL_B2C_NL");
        //                attachments.Set("product_details", "Dies ist eine Langbeschreibung");

        //                if (i % 500 == 0)
        //                {
        //                    subGroupId++;
        //                }
        //                attachments.Set("group_id", groupId.ToString());
        //                attachments.Set("subgroup_id", subGroupId.ToString());

        //                var data = File.ReadAllBytes(attachmentPath + "\\" + file);

        //                var blop = new Blob("image/jpg", data.Skip(rnd.Next(0, data.Length)).ToArray());

        //                attachments.Set(file.ToString(), blop);

        //                repsotary.InsertOrChange(attachments);
        //                numberOfFiles++;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
        //    sw.Stop();

        //    //Get article by article id
        //    Stopwatch sw3 = new Stopwatch();
        //    sw3.Start();
        //    var articlesincatalog = repsotary.Get("IFSID_2001");
        //    Console.WriteLine("Time: " + sw3.ElapsedMilliseconds);
        //    sw3.Stop();


        //    //Get article by catalog name
        //    Stopwatch sw1 = new Stopwatch();
        //    sw1.Start();
        //    var articles = repsotary.Get(Expression.Property("catalog_name").EqualTo("MIELE Domestic")).Count();
        //    Console.WriteLine("Time : " + sw1.ElapsedMilliseconds);
        //    sw1.Stop();

        //    //Get ar by catalog article id
        //    Stopwatch sw2 = new Stopwatch();
        //    sw2.Start();
        //    var articlesIncatalogs = repsotary.Get(Expression.Property("article_id").EqualTo("IFSID_14")).Count();
        //    Console.WriteLine("Time: " + sw2.ElapsedMilliseconds);
        //    sw2.Stop();

        //    Stopwatch sw4 = new Stopwatch();
        //    sw4.Start();
        //    var articlesInGroup = repsotary.Get(Expression.Property("group_id").EqualTo("1003")).Count();
        //    Console.WriteLine("Time: " + sw4.ElapsedMilliseconds);
        //    sw4.Stop();

        //    Stopwatch sw5 = new Stopwatch();
        //    sw5.Start();
        //    var articlesInSubGroup = repsotary.Get(Expression.Property("subgroup_id").EqualTo("2102")).Count();
        //    Console.WriteLine("Time: " + sw5.ElapsedMilliseconds);
        //    sw5.Stop();

        //    return articlesincatalog;
        //}

    }
}
