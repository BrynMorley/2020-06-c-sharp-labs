
function global:pushtogit
{
    git add .
    git commit -m $args[0]
    git push
}
# args is short for arguments
pushtogit $args[0]