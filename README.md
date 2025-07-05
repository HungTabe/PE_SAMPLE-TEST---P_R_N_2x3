# PE_SAMPLE-TEST---P_R_N_2x3

## Overview

The **PE_SAMPLE TEST** project is a web application developed to meet the requirements of a programming exercise (PE) focused on building a movie and director management system. The application is built using **ASP.NET Core Razor Pages** and adheres to specific guidelines for URL structure, data table configuration, HTML element IDs, and database connectivity via a connection string in `appsettings.json`. This document outlines the project requirements, implementation details, and key configurations.

---

## Project Requirements

### General Requirements

1. **Application Startup**:
   - The application must launch with the initial URL: `/Movies/Director_Movie`.
   - This URL is a strict requirement for automated grading; failure to comply results in a score of zero.

2. **Technology Stack**:
   - The application must be developed using **ASP.NET Core MVC** or **Razor Pages**.
   - **Razor Pages** was chosen for this implementation.

3. **Configuration**:
   - The database connection string must be defined in the `appsettings.json` file under the `connectionStrings` section.
   - The connection string configuration must match the specifications provided in the project requirements (refer to section 3 of the original guidelines).

4. **HTML Element IDs**:
   - All input and output HTML elements in the source code must have IDs that conform to the naming conventions specified in the project requirements.
   - Developers must refer to the provided source code (`src`) to ensure compliance.

---

### Data Table Configuration

#### Table Structure
The application displays data in a table format, with columns defined as per the provided guidelines (illustrated in "Figure 1" of the requirements). Key configurations include:

1. **Directors Column**:
   - The `directors` column contains links (`<a>` tags) for filtering movies by director.
   - Each `<a>` tag must have:
     - **ID Format**: `di_<director_id>`, where `<director_id>` is the unique identifier of the director.
     - **Content**: The name or relevant identifier of the director.
   - **Filtering Mechanism**:
     - Clicking an `<a>` tag in the `directors` column filters the table to display only movies associated with the selected director.

2. **Movies Table**:
   - The table displays movie data with columns such as `title`, `language`, and others as defined in the requirements.
   - **ID Naming Convention** for table cells (`<td>`):
     - **Format**: `td_<ColumnName>_<RowIndex>`.
     - **Horizontal Axis (Columns)**: `<ColumnName>` corresponds to the column name (e.g., `title`, `language`).
     - **Vertical Axis (Rows)**: `<RowIndex>` is a zero-based index incrementing from 0 to N, where N is the total number of rows.
     - **Example**:
       - For the `title` column in the first row: `td_title_0`.
       - For the `language` column in the second row: `td_language_1`.

---

### Question 1: Implementation Details

#### Part 1: Core Requirements
- **Razor Pages Implementation**:
  - The application uses Razor Pages to handle the rendering of the `/Movies/Director_Movie` page.
  - The page dynamically generates the movie and director data table based on the database query results.
- **Connection String**:
  - The database connection is configured in `appsettings.json` with the correct `connectionStrings` key.
  - Example structure (to be customized as per section 3 of the requirements):
    ```json
    {
      "connectionStrings": {
        "MyCnn": "<database_connection_string>"
      }
    }
    ```
- **HTML Compliance**:
  - All input/output elements (e.g., `<input>`, `<a>`, `<td>`) have IDs matching the specified formats.
  - The source code adheres to the provided `src` template for consistency.

#### Part 2: Directors and Filtering
- **Directors Column Configuration**:
  - The `<a>` tags in the `directors` column are generated dynamically based on the director data.
  - Each tag’s ID follows the `di_<director_id>` format.
  - Clicking a director link triggers a filter that updates the table to show only movies by the selected director.
- **Table Data IDs**:
  - The movie table cells are assigned IDs in the format `td_<ColumnName>_<RowIndex>`.
  - This ensures unique identification of each cell for potential interactions or automated testing.

