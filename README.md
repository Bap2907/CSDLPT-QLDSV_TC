# CSDLPT-QLDSV_TC
//Trên laptop
git init

git add .

git commit -m "Ghi chú"

//Lấy code về từ link
git clone https://github.com/Bap2907/CSDLPT-QLDSV_TC.git

//Clone 1 branch cụ thể
git clone -b (ten-branch) https://github.com/Bap2907/CSDLPT-QLDSV_TC.git

Tạo và chuyển sang branch mới
```
*a
git branch

git branch <ten branch moi>

git checkout <ten branch>

git checkout -b <ten branch moi>


```

Cập từ từ local lên github

```
  git remote add origin https://github.com/Bap2907/CSDLPT-QLDSV_TC.git (thêm url, tên origin)

  git push origin <ten branch>  
```


Gộp
```
  git checkout master/main

  git merge <ten branch>
