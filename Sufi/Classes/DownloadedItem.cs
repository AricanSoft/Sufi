using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementiumBrowser.Classes
{
    public class DownloadedItem
    {

        public int ID;
        public long Percent;
        public string FileName, FilePath, FileSize, FileURL, IsCompleted, CreateDate;

        Database db;
        public DownloadedItem()
        {
            db = new Database();
        }

        public bool Select()
        {
            if (ID <= 0) return false;
            var item = SelectList();
            if (item == null || item[0].ID != ID) return false;
            FileName = item[0].FileName;
            FilePath = item[0].FilePath;
            FileSize = item[0].FileSize;
            FileURL = item[0].FileURL;
            IsCompleted = item[0].IsCompleted;
            CreateDate = item[0].CreateDate;
            return true;
        }

        public DownloadedItem[] SelectList()
        {
            string sql = "SELECT * FROM tbl_downloaded_files WHERE (CASE WHEN {0} = -1 THEN 1=1 ELSE id = {0} END);";
            var list = db.GetObjects(sql);

            List<DownloadedItem> dlItems = new List<DownloadedItem>();
            foreach(var item in list)
            {
                var downloadedItem = new DownloadedItem();
                downloadedItem.ID = item["id"].ToInt32();
                downloadedItem.FileName = item["file_name"].ToString();
                downloadedItem.FilePath = item["file_path"].ToString();
                downloadedItem.FileURL = item["file_url"].ToString();
                downloadedItem.FileSize = item["file_size"].ToString();
                downloadedItem.IsCompleted = item["is_complete"].ToString();
                downloadedItem.CreateDate = item["create_date"].ToString();
                dlItems.Add(downloadedItem);
            }

            return dlItems.ToArray();
        }

        public bool Insert()
        {
            try
            {
                string sql =
                    string.Format("INSERT INTO tbl_downloaded_items(file_name,file_path,file_url,file_size,is_complete,create_date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                    FileName,FilePath, FileURL, FileSize, IsCompleted,CreateDate
                    );
                db.ExecuteQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
