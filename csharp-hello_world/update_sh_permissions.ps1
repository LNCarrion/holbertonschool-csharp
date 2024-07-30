# Get all .sh files tracked by git
$shFiles = git ls-files "*.sh"

# Update the file mode to executable for each .sh file
foreach ($file in $shFiles) {
    git update-index --chmod=+x $file
}