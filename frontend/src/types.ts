// src/types.ts
export interface Bowler {
    bowlerID: number;
    bowlerLastName: string;
    bowlerFirstName: string;
    bowlerMiddleInit: string | null;
    bowlerAddress: string;
    bowlerCity: string;
    bowlerState: string;
    bowlerZip: string;
    bowlerPhoneNumber: string;
    teamID: number;
    team: Team;
}

export interface Team {
    teamID: number;
    teamName: string;
    captainID: number | null;
}