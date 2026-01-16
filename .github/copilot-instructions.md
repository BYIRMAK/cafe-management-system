# GitHub Copilot Instructions for Cafe Management System

## Project Overview
This is a cafe management system repository. The system is designed to help manage cafe operations efficiently.

## Code Style and Conventions

### General Guidelines
- Write clean, maintainable, and well-documented code
- Follow language-specific best practices and conventions
- Use meaningful variable and function names
- Keep functions small and focused on a single responsibility
- Add comments for complex logic

### Naming Conventions
- Use descriptive names that clearly indicate purpose
- Follow consistent naming patterns throughout the codebase
- Use camelCase for variables and functions in JavaScript/TypeScript
- Use PascalCase for classes and components
- Use UPPER_CASE for constants

## Testing Requirements
- Write unit tests for new functionality
- Ensure tests are comprehensive and cover edge cases
- Follow existing test patterns in the repository
- Run tests before submitting changes
- Maintain or improve code coverage

## Development Guidelines

### Code Quality
- Follow DRY (Don't Repeat Yourself) principle
- Implement proper error handling
- Validate inputs and sanitize outputs
- Write self-documenting code
- Use type safety when available

### Security Best Practices
- Never commit sensitive data (API keys, passwords, credentials)
- Sanitize user inputs to prevent injection attacks
- Use parameterized queries for database operations
- Implement proper authentication and authorization
- Follow OWASP security guidelines

### Performance
- Optimize database queries
- Implement caching where appropriate
- Avoid unnecessary computations
- Use asynchronous operations for I/O operations
- Profile and optimize bottlenecks

## Common Patterns

### Error Handling
- Use try-catch blocks for error-prone operations
- Provide meaningful error messages
- Log errors appropriately
- Handle errors gracefully without crashing

### Documentation
- Add JSDoc/docstring comments for public APIs
- Keep README up to date
- Document configuration options
- Include usage examples

## Build and Deployment
- Follow the build process defined in the repository
- Test locally before pushing changes
- Ensure builds pass successfully
- Follow semantic versioning for releases

## Contributing
- Create feature branches for new work
- Write clear commit messages
- Keep commits focused and atomic
- Review your own code before requesting review
- Address review feedback promptly

## Additional Notes
- Prioritize code readability over cleverness
- Refactor code when needed to maintain quality
- Stay consistent with existing codebase patterns
- Ask questions when requirements are unclear
