from pathlib import Path
import json
import glob
import pandas as pd

cwd = Path.cwd()
file = cwd.parents[0] / 'GevorgyanA' / 'AC.json'

with open('AC.json', encoding='utf-8') as f:
    data = json.load(f),
    df=pd.read_json(r"C:\\Revature\\230206-NET\\GevorgyanA\\AC.json")
    df_name=pd.DataFrame.from_records(df["name"])["name-USen"]
    df_url=df["image_uri"]
    df_name.to_csv("ACname.csv")
    df_url.to_csv("ACurl.csv")


 
# list all csv files only
csv_files = glob.glob('*.{}'.format('csv'))

df_csv_append = pd.DataFrame()
 
# append the CSV files
for file in csv_files:
    df = pd.read_csv(file)
    df_csv_append = pd.concat([pd.read_csv(file) for file in csv_files ], axis=1)

df_csv_append.to_csv("Final.csv")




