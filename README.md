# Automation-Software

This project content is Fuel Tanks Automation Software written by C#.

Autiomation means fluel level data reading (Level, Temperature, Volume ..) from tanks using SaabTankRadar equipments which provided DA OPC Server.
Data reading occurs by OPC client which worked at separated thread.

Collecting data from all tanks was saved to MS SQL Server Express 2019.
For data exchanging from database and software used Entity Framework.
Database model was created at Microsoft SQL Server Management Studio and transfered to C# software.

Software provide:
- user interface to see all runtime data from SaabTankRadar;
- commercial sell/buy operations register;
- commercial report's creator;
- user secruty manager;
- fuel tank data configuration and calibration by measured level data.

