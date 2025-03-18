import { Bowler } from '../types';

interface BowlerTableProps {
    bowlers: Bowler[];
}

const BowlerTable = ({ bowlers }: BowlerTableProps) => {
    return (
        <table style={{ width: "100%", borderCollapse: "collapse", margin: "20px 0" }}>
            <thead>
                <tr style={{ backgroundColor: "#f2f2f2" }}>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>Name</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>Team</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>Address</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>City</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>State</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>Zip</th>
                    <th style={{ padding: "12px", textAlign: "left", borderBottom: "1px solid #ddd" }}>Phone Number</th>
                </tr>
            </thead>
            <tbody>
                {bowlers.map((bowler) => (
                    <tr key={bowler.bowlerID} style={{ borderBottom: "1px solid #ddd" }}>
                        <td style={{ padding: "12px" }}>{`${bowler.bowlerFirstName} ${bowler.bowlerMiddleInit || ""} ${bowler.bowlerLastName}`}</td>
                        <td style={{ padding: "12px" }}>{bowler.team?.teamName}</td>
                        <td style={{ padding: "12px" }}>{bowler.bowlerAddress}</td>
                        <td style={{ padding: "12px" }}>{bowler.bowlerCity}</td>
                        <td style={{ padding: "12px" }}>{bowler.bowlerState}</td>
                        <td style={{ padding: "12px" }}>{bowler.bowlerZip}</td>
                        <td style={{ padding: "12px" }}>{bowler.bowlerPhoneNumber}</td>
                    </tr>
                ))}
            </tbody>
        </table>
    );
};
export default BowlerTable;