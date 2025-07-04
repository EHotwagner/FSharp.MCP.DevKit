# Personal Git Tips

## Daily Development Workflow: Feature Branch → Squash → Main

Working on a feature branch for a day and then squashing commits before merging to main.

### 1. Create and Switch to Dev Branch

```bash
# Create and switch to a new dev branch
git checkout -b feature/my-feature

# Or if you prefer the newer syntax
git switch -c feature/my-feature
```

### 2. Work Throughout the Day

Make your commits as usual - don't worry about commit message quality:

```bash
# Make changes, then commit
git add .
git commit -m "wip: initial changes"

# More changes
git add .
git commit -m "fix typo"

# More changes
git add .
git commit -m "add new feature"

# etc...
```

### 3. When Ready to Merge (Two Main Approaches)

#### Option A: Squash Merge (Recommended - Simpler)

```bash
# Switch back to main
git checkout main

# Make sure main is up to date
git pull origin main

# Merge with squash (combines all commits into one)
git merge --squash feature/my-feature

# This stages all changes but doesn't commit yet
# Now create a single, clean commit
git commit -m "feat: Add comprehensive new feature

- Implemented core functionality
- Fixed related bugs
- Updated documentation"

# Push to main
git push origin main

# Clean up the feature branch
git branch -d feature/my-feature
```

#### Option B: Interactive Rebase (More Control)

```bash
# Stay on your feature branch
git checkout feature/my-feature

# Interactive rebase to squash commits
git rebase -i HEAD~5  # Replace 5 with number of commits to squash

# In the editor that opens, change 'pick' to 'squash' (or 's') for all but the first commit:
# pick abc1234 First commit
# squash def5678 Second commit  
# squash ghi9012 Third commit
# squash jkl3456 Fourth commit
# squash mno7890 Fifth commit

# Save and close, then edit the commit message in the next editor

# Now merge to main
git checkout main
git pull origin main
git merge feature/my-feature
git push origin main

# Clean up
git branch -d feature/my-feature
```

### 4. Alternative: Squash on GitHub/GitLab

If you're using GitHub or GitLab:

```bash
# Push your feature branch with all commits
git push origin feature/my-feature

# Create a Pull Request/Merge Request
# When merging, select "Squash and merge" option
# This automatically squashes all commits into one
```

## Best Practices

1. **Branch Naming**: Use descriptive names like `feature/add-documentation-tools` or `fix/memory-leak`

2. **Commit Message for Squashed Commit**: Write a comprehensive message:
   ```
   feat: Add comprehensive documentation generation system
   
   - Implement package documentation generation
   - Add smart search capabilities
   - Include API reference generation
   - Add configuration management
   - Update project documentation
   
   Closes #123
   ```

3. **Keep Feature Branches Short-lived**: Ideally 1-3 days to avoid conflicts

4. **Regular Pulls**: If working on a shared repository, pull main regularly:
   ```bash
   git checkout main
   git pull origin main
   git checkout feature/my-feature
   git rebase main  # or git merge main
   ```

## Recovery: Already on Main with Multiple Commits

If you're already on main with multiple commits you want to squash:

### Option 1: Create Feature Branch from Earlier Commit
```bash
# Find the commit before your work started
git log --oneline

# Create branch from that point
git branch feature/current-work HEAD~10  # Adjust number

# Reset main to clean state
git reset --hard HEAD~10

# Work with the feature branch
git checkout feature/current-work
```

### Option 2: Soft Reset and Recommit
```bash
# Soft reset to earlier commit (keeps changes staged)
git reset --soft HEAD~10  # Adjust number

# Create a single new commit
git commit -m "feat: Comprehensive changes

- List all the changes made
- Group related changes
- Explain the overall purpose"
```

## Quick Reference Commands

```bash
# Check current branch and status
git status
git branch

# See commit history
git log --oneline -10

# Squash last N commits (interactive)
git rebase -i HEAD~N

# Squash merge a feature branch
git merge --squash feature-branch-name

# Clean up merged branches
git branch -d feature-branch-name
```